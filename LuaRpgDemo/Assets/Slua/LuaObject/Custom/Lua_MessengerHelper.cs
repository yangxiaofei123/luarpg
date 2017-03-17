using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_MessengerHelper : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnDisable(IntPtr l) {
		try {
			MessengerHelper self=(MessengerHelper)checkSelf(l);
			self.OnDisable();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnApplicationQuit(IntPtr l) {
		try {
			MessengerHelper self=(MessengerHelper)checkSelf(l);
			self.OnApplicationQuit();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"MessengerHelper");
		addMember(l,OnDisable);
		addMember(l,OnApplicationQuit);
		createTypeMetatable(l,null, typeof(MessengerHelper),typeof(UnityEngine.MonoBehaviour));
	}
}
