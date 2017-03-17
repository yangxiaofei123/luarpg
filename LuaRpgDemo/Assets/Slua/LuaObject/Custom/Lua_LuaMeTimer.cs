using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LuaMeTimer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_obj(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,LuaMeTimer.obj);
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
			LuaMeTimer.obj=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_TimerList(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,LuaMeTimer.TimerList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_TimerList(IntPtr l) {
		try {
			System.Collections.Generic.List<MeTimer> v;
			checkType(l,2,out v);
			LuaMeTimer.TimerList=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LuaMeTimer");
		addMember(l,"obj",get_obj,set_obj,false);
		addMember(l,"TimerList",get_TimerList,set_TimerList,false);
		createTypeMetatable(l,null, typeof(LuaMeTimer),typeof(UnityEngine.MonoBehaviour));
	}
}
