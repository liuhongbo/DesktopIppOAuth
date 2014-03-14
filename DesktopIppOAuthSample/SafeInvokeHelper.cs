using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DesktopIppOAuthSample
{
    //http://dotnetjunkies.com/WebLog/johnwood/archive/2005/08/31/132267.aspx
    public class SafeInvokeHelper
    {
        static readonly ModuleBuilder builder;
        static readonly AssemblyBuilder myAsmBuilder;
        static readonly Hashtable methodLookup;

        static SafeInvokeHelper()
        {
            AssemblyName name = new AssemblyName();
            name.Name = "temp";
            myAsmBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(name, AssemblyBuilderAccess.Run);
            builder = myAsmBuilder.DefineDynamicModule("TempModule");
            methodLookup = new Hashtable();
        }

        public static object Invoke(System.Windows.Forms.Control obj, string methodName, params object[] paramValues)
        {
            Delegate del = null;
            string key = obj.GetType().Name + "." + methodName;
            Type tp;
            lock (methodLookup)
            {
                if (methodLookup.Contains(key))
                    tp = (Type)methodLookup[key];
                else
                {
                    Type[] paramList = new Type[obj.GetType().GetMethod(methodName).GetParameters().Length];
                    int n = 0;
                    foreach (ParameterInfo pi in obj.GetType().GetMethod(methodName).GetParameters()) paramList[n++] = pi.ParameterType;
                    TypeBuilder typeB = builder.DefineType("Del_" + obj.GetType().Name + "_" + methodName, TypeAttributes.Class | TypeAttributes.AutoLayout | TypeAttributes.Public | TypeAttributes.Sealed, typeof(MulticastDelegate), PackingSize.Unspecified);
                    ConstructorBuilder conB = typeB.DefineConstructor(MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName, CallingConventions.Standard, new Type[] { typeof(object), typeof(IntPtr) });
                    conB.SetImplementationFlags(MethodImplAttributes.Runtime);
                    MethodBuilder mb = typeB.DefineMethod("Invoke", MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig, obj.GetType().GetMethod(methodName).ReturnType, paramList);
                    mb.SetImplementationFlags(MethodImplAttributes.Runtime);
                    tp = typeB.CreateType();
                    methodLookup.Add(key, tp);
                }
            }

            del = MulticastDelegate.CreateDelegate(tp, obj, methodName);
            return obj.Invoke(del, paramValues);
        }

        public static object InvokeProperty(System.Windows.Forms.Control obj, string propertyName, params object[] paramValues)
        {
            Delegate del = null;
            string key = obj.GetType().Name + "." + propertyName;
            Type tp;
            lock (methodLookup)
            {
                if (methodLookup.Contains(key))
                    tp = (Type)methodLookup[key];
                else
                {
                    Type[] paramList = new Type[obj.GetType().GetProperty(propertyName).GetSetMethod().GetParameters().Length];
                    int n = 0;
                    foreach (ParameterInfo pi in obj.GetType().GetProperty(propertyName).GetSetMethod().GetParameters()) paramList[n++] = pi.ParameterType;
                    TypeBuilder typeB = builder.DefineType("Del_" + obj.GetType().Name + "_" + propertyName, TypeAttributes.Class | TypeAttributes.AutoLayout | TypeAttributes.Public | TypeAttributes.Sealed, typeof(MulticastDelegate), PackingSize.Unspecified);
                    ConstructorBuilder conB = typeB.DefineConstructor(MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName, CallingConventions.Standard, new Type[] { typeof(object), typeof(IntPtr) });
                    conB.SetImplementationFlags(MethodImplAttributes.Runtime);
                    MethodBuilder mb = typeB.DefineMethod("Invoke", MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig, obj.GetType().GetProperty(propertyName).GetSetMethod().ReturnType, paramList);
                    mb.SetImplementationFlags(MethodImplAttributes.Runtime);
                    tp = typeB.CreateType();
                    methodLookup.Add(key, tp);
                }
            }

            del = MulticastDelegate.CreateDelegate(tp, obj, obj.GetType().GetProperty(propertyName).GetSetMethod().Name);
            return obj.Invoke(del, paramValues);
        }
    }
}
