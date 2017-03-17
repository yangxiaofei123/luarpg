using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_WebClientEx : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			WebClientEx o;
			if(argc==1){
				o=new WebClientEx();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==2){
				System.Int32 a1;
				checkType(l,2,out a1);
				o=new WebClientEx(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int downFile(IntPtr l) {
		try {
			WebClientEx self=(WebClientEx)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.downFile(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Close(IntPtr l) {
		try {
			WebClientEx self=(WebClientEx)checkSelf(l);
			self.Close();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_progress(IntPtr l) {
		try {
			WebClientEx self=(WebClientEx)checkSelf(l);
			WebClientEx.DownProgress v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.progress=v;
			else if(op==1) self.progress+=v;
			else if(op==2) self.progress-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_complete(IntPtr l) {
		try {
			WebClientEx self=(WebClientEx)checkSelf(l);
			WebClientEx.DownComplete v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.complete=v;
			else if(op==1) self.complete+=v;
			else if(op==2) self.complete-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Timeout(IntPtr l) {
		try {
			WebClientEx self=(WebClientEx)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Timeout);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_Timeout(IntPtr l) {
		try {
			WebClientEx self=(WebClientEx)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.Timeout=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"WebClientEx");
		addMember(l,downFile);
		addMember(l,Close);
		addMember(l,"progress",null,set_progress,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"Timeout",get_Timeout,set_Timeout,true);
		createTypeMetatable(l,constructor, typeof(WebClientEx),typeof(System.Net.WebClient));
	}
}
