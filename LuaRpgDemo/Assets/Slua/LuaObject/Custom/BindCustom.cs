using System;
using System.Collections.Generic;
namespace SLua {
	[LuaBinder(3)]
	public class BindCustom {
		public static Action<IntPtr>[] GetBindList() {
			Action<IntPtr>[] list= {
				Lua_LTDescr.reg,
				Lua_LeanTweenType.reg,
				Lua_LeanTween.reg,
				Lua_MessengerHelper.reg,
				Lua_API.reg,
				Lua_LuaBehaviour.reg,
				Lua_Activity.reg,
				Lua_DebugTools.reg,
				Lua_LuaMeTimer.reg,
				Lua_MeTimer.reg,
				Lua_WebClientEx.reg,
				Lua_EventListener.reg,
				Lua_Lua.reg,
				Lua_Custom.reg,
				Lua_Deleg.reg,
				Lua_foostruct.reg,
				Lua_FloatEvent.reg,
				Lua_ListViewEvent.reg,
				Lua_SLuaTest.reg,
				Lua_System_Collections_Generic_List_1_int.reg,
				Lua_XXList.reg,
				Lua_AbsClass.reg,
				Lua_HelloWorld.reg,
				Lua_System_Collections_Generic_Dictionary_2_int_string.reg,
				Lua_System_String.reg,
			};
			return list;
		}
	}
}
