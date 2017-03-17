using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_MeTimer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			MeTimer o;
			o=new MeTimer();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_id(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.id);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_id(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.id=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onTimer(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			Callback<MeTimer> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onTimer=v;
			else if(op==1) self.onTimer+=v;
			else if(op==2) self.onTimer-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onCompleted(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			Callback<MeTimer> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onCompleted=v;
			else if(op==1) self.onCompleted+=v;
			else if(op==2) self.onCompleted-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_interval(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.interval);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_interval(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.interval=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaTime(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.deltaTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_deltaTime(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.deltaTime=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delay(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.delay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delay(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.delay=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loop(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.loop);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_loop(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.loop=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_count(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.count);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_count(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.count=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.enabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_close(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.close);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_close(IntPtr l) {
		try {
			MeTimer self=(MeTimer)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.close=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"MeTimer");
		addMember(l,"id",get_id,set_id,true);
		addMember(l,"onTimer",null,set_onTimer,true);
		addMember(l,"onCompleted",null,set_onCompleted,true);
		addMember(l,"interval",get_interval,set_interval,true);
		addMember(l,"deltaTime",get_deltaTime,set_deltaTime,true);
		addMember(l,"delay",get_delay,set_delay,true);
		addMember(l,"loop",get_loop,set_loop,true);
		addMember(l,"count",get_count,set_count,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"close",get_close,set_close,true);
		createTypeMetatable(l,constructor, typeof(MeTimer));
	}
}
