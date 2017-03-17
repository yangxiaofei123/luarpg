using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_API : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			API o;
			o=new API();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CleanLuaEnv_s(IntPtr l) {
		try {
			API.CleanLuaEnv();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Log_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			API.Log(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LogError_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			API.LogError(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LogWarning_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			API.LogWarning(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddComponent_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(System.Type))){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				System.Type a2;
				checkType(l,2,out a2);
				var ret=API.AddComponent(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GameObject),typeof(string))){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				var ret=API.AddComponent(a1,a2);
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
	static public int AddMissComponent_s(IntPtr l) {
		try {
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=API.AddMissComponent(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StartCoroutine_s(IntPtr l) {
		try {
			System.Collections.IEnumerator a1;
			checkType(l,1,out a1);
			API.StartCoroutine(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RunCoroutine_s(IntPtr l) {
		try {
			UnityEngine.YieldInstruction a1;
			checkType(l,1,out a1);
			SLua.LuaFunction a2;
			checkType(l,2,out a2);
			System.Object a3;
			checkType(l,3,out a3);
			API.RunCoroutine(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PackFiles_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			API.PackFiles(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnpackFiles_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=API.UnpackFiles(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SendRequest_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			SLua.LuaFunction a3;
			checkType(l,3,out a3);
			API.SendRequest(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DownLoad_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Object a3;
			checkType(l,3,out a3);
			SLua.LuaFunction a4;
			checkType(l,4,out a4);
			SLua.LuaFunction a5;
			checkType(l,5,out a5);
			API.DownLoad(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddTimer_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.Single a1;
				checkType(l,1,out a1);
				Callback<MeTimer> a2;
				LuaDelegation.checkDelegate(l,2,out a2);
				var ret=API.AddTimer(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				System.Single a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				Callback<MeTimer> a3;
				LuaDelegation.checkDelegate(l,3,out a3);
				var ret=API.AddTimer(a1,a2,a3);
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
	static public int KillTimer_s(IntPtr l) {
		try {
			MeTimer a1;
			checkType(l,1,out a1);
			API.KillTimer(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HashToMD5Hex_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=API.HashToMD5Hex(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MD5_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=API.MD5(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MD5File_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=API.MD5File(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RC4_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(System.Byte[]),typeof(string))){
				System.Byte[] a1;
				checkArray(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				var ret=API.RC4(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				var ret=API.RC4(a1,a2);
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
	static public int Encrypt_s(IntPtr l) {
		try {
			System.Byte[] a1;
			checkType(l,1,out a1);
			API.Encrypt(ref a1);
			pushValue(l,true);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EncryptAll_s(IntPtr l) {
		try {
			System.Byte[] a1;
			checkType(l,1,out a1);
			API.EncryptAll(ref a1);
			pushValue(l,true);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StreamToBytes_s(IntPtr l) {
		try {
			System.IO.Stream a1;
			checkType(l,1,out a1);
			var ret=API.StreamToBytes(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BytesToStream_s(IntPtr l) {
		try {
			System.Byte[] a1;
			checkArray(l,1,out a1);
			var ret=API.BytesToStream(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				UnityEngine.RaycastHit a2;
				var ret=API.Raycast(a1,out a2);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a2);
				return 3;
			}
			else if(argc==4){
				UnityEngine.Ray a1;
				checkValueType(l,1,out a1);
				UnityEngine.RaycastHit a2;
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=API.Raycast(a1,out a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a2);
				return 3;
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
	static public int LoadBundle_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				Callback<System.String,UnityEngine.AssetBundle,System.Object> a2;
				LuaDelegation.checkDelegate(l,2,out a2);
				API.LoadBundle(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				System.String a1;
				checkType(l,1,out a1);
				Callback<System.String,UnityEngine.AssetBundle,System.Object> a2;
				LuaDelegation.checkDelegate(l,2,out a2);
				System.Object a3;
				checkType(l,3,out a3);
				API.LoadBundle(a1,a2,a3);
				pushValue(l,true);
				return 1;
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
	static public int UnLoadAllBundle_s(IntPtr l) {
		try {
			API.UnLoadAllBundle();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnLoadBundle_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				API.UnLoadBundle(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.AssetBundle))){
				UnityEngine.AssetBundle a1;
				checkType(l,1,out a1);
				API.UnLoadBundle(a1);
				pushValue(l,true);
				return 1;
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
	static public int StopAllLoadBundle_s(IntPtr l) {
		try {
			API.StopAllLoadBundle();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddListener_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			Callback a2;
			LuaDelegation.checkDelegate(l,2,out a2);
			API.AddListener(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddListener2_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			Callback<System.Object> a2;
			LuaDelegation.checkDelegate(l,2,out a2);
			API.AddListener2(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveListener_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			Callback a2;
			LuaDelegation.checkDelegate(l,2,out a2);
			API.RemoveListener(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveListener2_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			Callback<System.Object> a2;
			LuaDelegation.checkDelegate(l,2,out a2);
			API.RemoveListener2(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Broadcast_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				API.Broadcast(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.Object a2;
				checkType(l,2,out a2);
				API.Broadcast(a1,a2);
				pushValue(l,true);
				return 1;
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
	static public int IsPointerOverUIObject_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==0){
				var ret=API.IsPointerOverUIObject();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Canvas a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				var ret=API.IsPointerOverUIObject(a1,a2);
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
	static public int get_BundleTable(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,API.BundleTable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_BundleTable(IntPtr l) {
		try {
			System.Collections.Hashtable v;
			checkType(l,2,out v);
			API.BundleTable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Encrypt_Len(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,API.Encrypt_Len);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_Encrypt_Len(IntPtr l) {
		try {
			System.Int32 v;
			checkType(l,2,out v);
			API.Encrypt_Len=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Encrypt_Key(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,API.Encrypt_Key);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_Encrypt_Key(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			API.Encrypt_Key=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_assetbundle_extension(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,API.assetbundle_extension);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_assetbundle_extension(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			API.assetbundle_extension=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_usingDebug(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,API.usingDebug);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_usingDebug(IntPtr l) {
		try {
			System.Boolean v;
			checkType(l,2,out v);
			API.usingDebug=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_usingEncryptLua(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,API.usingEncryptLua);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_usingEncryptLua(IntPtr l) {
		try {
			System.Boolean v;
			checkType(l,2,out v);
			API.usingEncryptLua=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_env(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,API.env);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_AssetRoot(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,API.AssetRoot);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_AssetRoot(IntPtr l) {
		try {
			string v;
			checkType(l,2,out v);
			API.AssetRoot=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_AssetPath(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,API.AssetPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_AssetPath(IntPtr l) {
		try {
			string v;
			checkType(l,2,out v);
			API.AssetPath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_GetTargetPlatform(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,API.GetTargetPlatform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"API");
		addMember(l,CleanLuaEnv_s);
		addMember(l,Log_s);
		addMember(l,LogError_s);
		addMember(l,LogWarning_s);
		addMember(l,AddComponent_s);
		addMember(l,AddMissComponent_s);
		addMember(l,StartCoroutine_s);
		addMember(l,RunCoroutine_s);
		addMember(l,PackFiles_s);
		addMember(l,UnpackFiles_s);
		addMember(l,SendRequest_s);
		addMember(l,DownLoad_s);
		addMember(l,AddTimer_s);
		addMember(l,KillTimer_s);
		addMember(l,HashToMD5Hex_s);
		addMember(l,MD5_s);
		addMember(l,MD5File_s);
		addMember(l,RC4_s);
		addMember(l,Encrypt_s);
		addMember(l,EncryptAll_s);
		addMember(l,StreamToBytes_s);
		addMember(l,BytesToStream_s);
		addMember(l,Raycast_s);
		addMember(l,LoadBundle_s);
		addMember(l,UnLoadAllBundle_s);
		addMember(l,UnLoadBundle_s);
		addMember(l,StopAllLoadBundle_s);
		addMember(l,AddListener_s);
		addMember(l,AddListener2_s);
		addMember(l,RemoveListener_s);
		addMember(l,RemoveListener2_s);
		addMember(l,Broadcast_s);
		addMember(l,IsPointerOverUIObject_s);
		addMember(l,"BundleTable",get_BundleTable,set_BundleTable,false);
		addMember(l,"Encrypt_Len",get_Encrypt_Len,set_Encrypt_Len,false);
		addMember(l,"Encrypt_Key",get_Encrypt_Key,set_Encrypt_Key,false);
		addMember(l,"assetbundle_extension",get_assetbundle_extension,set_assetbundle_extension,false);
		addMember(l,"usingDebug",get_usingDebug,set_usingDebug,false);
		addMember(l,"usingEncryptLua",get_usingEncryptLua,set_usingEncryptLua,false);
		addMember(l,"env",get_env,null,false);
		addMember(l,"AssetRoot",get_AssetRoot,set_AssetRoot,false);
		addMember(l,"AssetPath",get_AssetPath,set_AssetPath,false);
		addMember(l,"GetTargetPlatform",get_GetTargetPlatform,null,false);
		createTypeMetatable(l,constructor, typeof(API));
	}
}
