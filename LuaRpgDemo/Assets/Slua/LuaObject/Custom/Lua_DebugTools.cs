using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_DebugTools : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_log(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,DebugTools.log);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_log(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			DebugTools.log=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_obj(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,DebugTools.obj);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_obj(IntPtr l) {
		try {
			UnityEngine.GameObject v;
			checkType(l,2,out v);
			DebugTools.obj=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"DebugTools");
		addMember(l,"log",get_log,set_log,false);
		addMember(l,"obj",get_obj,set_obj,false);
		createTypeMetatable(l,null, typeof(DebugTools),typeof(UnityEngine.MonoBehaviour));
	}
}
