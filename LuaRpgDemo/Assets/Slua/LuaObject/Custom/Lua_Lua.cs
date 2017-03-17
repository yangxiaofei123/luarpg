using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Lua : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			Lua o;
			o=new Lua();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dispose(IntPtr l) {
		try {
			Lua self=(Lua)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DoFile(IntPtr l) {
		try {
			Lua self=(Lua)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.DoFile(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetFunction(IntPtr l) {
		try {
			Lua self=(Lua)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetFunction(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_luaState(IntPtr l) {
		try {
			Lua self=(Lua)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.luaState);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_luaState(IntPtr l) {
		try {
			Lua self=(Lua)checkSelf(l);
			SLua.LuaState v;
			checkType(l,2,out v);
			self.luaState=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isReady(IntPtr l) {
		try {
			Lua self=(Lua)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isReady);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isReady(IntPtr l) {
		try {
			Lua self=(Lua)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isReady=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int getItem(IntPtr l) {
		try {
			Lua self=(Lua)checkSelf(l);
			string v;
			checkType(l,2,out v);
			var ret = self[v];
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setItem(IntPtr l) {
		try {
			Lua self=(Lua)checkSelf(l);
			string v;
			checkType(l,2,out v);
			System.Object c;
			checkType(l,3,out c);
			self[v]=c;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"Lua");
		addMember(l,Dispose);
		addMember(l,DoFile);
		addMember(l,GetFunction);
		addMember(l,getItem);
		addMember(l,setItem);
		addMember(l,"luaState",get_luaState,set_luaState,true);
		addMember(l,"isReady",get_isReady,set_isReady,true);
		createTypeMetatable(l,constructor, typeof(Lua));
	}
}
