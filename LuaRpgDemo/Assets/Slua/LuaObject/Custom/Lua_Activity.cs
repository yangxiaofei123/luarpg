using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Activity : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			Activity o;
			o=new Activity();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReStart(IntPtr l) {
		try {
			Activity self=(Activity)checkSelf(l);
			self.ReStart();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"Activity");
		addMember(l,ReStart);
		createTypeMetatable(l,constructor, typeof(Activity),typeof(LuaBehaviour));
	}
}
