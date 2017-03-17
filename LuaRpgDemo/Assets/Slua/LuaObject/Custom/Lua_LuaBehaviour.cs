using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LuaBehaviour : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setBehaviour(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			SLua.LuaTable a1;
			checkType(l,2,out a1);
			self.setBehaviour(a1);
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
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Action a2;
			LuaDelegation.checkDelegate(l,3,out a2);
			self.DoFile(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetChunk(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			var ret=self.GetChunk();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetEnv(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.SetEnv(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LuaInvoke(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			SLua.LuaFunction a2;
			checkType(l,3,out a2);
			System.Object[] a3;
			checkParams(l,4,out a3);
			self.LuaInvoke(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RunCoroutine(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			UnityEngine.YieldInstruction a1;
			checkType(l,2,out a1);
			SLua.LuaFunction a2;
			checkType(l,3,out a2);
			System.Object[] a3;
			checkParams(l,4,out a3);
			self.RunCoroutine(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CancelCoroutine(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			UnityEngine.YieldInstruction a1;
			checkType(l,2,out a1);
			SLua.LuaFunction a2;
			checkType(l,3,out a2);
			System.Object[] a3;
			checkParams(l,4,out a3);
			self.CancelCoroutine(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CallMethod(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				LuaBehaviour self=(LuaBehaviour)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.CallMethod(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				LuaBehaviour self=(LuaBehaviour)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object[] a2;
				checkParams(l,3,out a2);
				var ret=self.CallMethod(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MeMessage(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			self.MeMessage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MeMessageAll(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			self.MeMessageAll(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FormatException_s(IntPtr l) {
		try {
			System.Exception a1;
			checkType(l,1,out a1);
			var ret=LuaBehaviour.FormatException(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_usingUpdate(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.usingUpdate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_usingUpdate(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.usingUpdate=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_usingFixedUpdate(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.usingFixedUpdate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_usingFixedUpdate(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.usingFixedUpdate=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_usingLateUpdate(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.usingLateUpdate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_usingLateUpdate(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.usingLateUpdate=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_LuaName(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.LuaName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_LuaName(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.LuaName=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_data(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.data);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_data(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			SLua.LuaTable v;
			checkType(l,2,out v);
			self.data=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LuaBehaviour");
		addMember(l,setBehaviour);
		addMember(l,DoFile);
		addMember(l,GetChunk);
		addMember(l,SetEnv);
		addMember(l,LuaInvoke);
		addMember(l,RunCoroutine);
		addMember(l,CancelCoroutine);
		addMember(l,CallMethod);
		addMember(l,MeMessage);
		addMember(l,MeMessageAll);
		addMember(l,FormatException_s);
		addMember(l,"usingUpdate",get_usingUpdate,set_usingUpdate,true);
		addMember(l,"usingFixedUpdate",get_usingFixedUpdate,set_usingFixedUpdate,true);
		addMember(l,"usingLateUpdate",get_usingLateUpdate,set_usingLateUpdate,true);
		addMember(l,"LuaName",get_LuaName,set_LuaName,true);
		addMember(l,"data",get_data,set_data,true);
		createTypeMetatable(l,null, typeof(LuaBehaviour),typeof(UnityEngine.MonoBehaviour));
	}
}
