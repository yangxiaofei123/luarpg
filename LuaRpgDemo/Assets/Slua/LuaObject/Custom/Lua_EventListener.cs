using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_EventListener : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerClick(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerClick(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerDown(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerDown(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerEnter(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerEnter(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerExit(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerExit(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerUp(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerUp(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnSelect(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnSelect(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnSubmit(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnSubmit(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Get_s(IntPtr l) {
		try {
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			var ret=EventListener.Get(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onClick(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			EventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onClick=v;
			else if(op==1) self.onClick+=v;
			else if(op==2) self.onClick-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDown(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			EventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onDown=v;
			else if(op==1) self.onDown+=v;
			else if(op==2) self.onDown-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onEnter(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			EventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onEnter=v;
			else if(op==1) self.onEnter+=v;
			else if(op==2) self.onEnter-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onExit(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			EventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onExit=v;
			else if(op==1) self.onExit+=v;
			else if(op==2) self.onExit-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onUp(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			EventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onUp=v;
			else if(op==1) self.onUp+=v;
			else if(op==2) self.onUp-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onSelect(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			EventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onSelect=v;
			else if(op==1) self.onSelect+=v;
			else if(op==2) self.onSelect-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onUpdateSelect(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			EventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onUpdateSelect=v;
			else if(op==1) self.onUpdateSelect+=v;
			else if(op==2) self.onUpdateSelect-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onSubmit(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			EventListener.BaseEventDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onSubmit=v;
			else if(op==1) self.onSubmit+=v;
			else if(op==2) self.onSubmit-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onTriggerEnter(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			EventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onTriggerEnter=v;
			else if(op==1) self.onTriggerEnter+=v;
			else if(op==2) self.onTriggerEnter-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onTriggerStay(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			EventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onTriggerStay=v;
			else if(op==1) self.onTriggerStay+=v;
			else if(op==2) self.onTriggerStay-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onTriggerExit(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			EventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onTriggerExit=v;
			else if(op==1) self.onTriggerExit+=v;
			else if(op==2) self.onTriggerExit-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onCollisionEnter(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			EventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onCollisionEnter=v;
			else if(op==1) self.onCollisionEnter+=v;
			else if(op==2) self.onCollisionEnter-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onCollisionStay(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			EventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onCollisionStay=v;
			else if(op==1) self.onCollisionStay+=v;
			else if(op==2) self.onCollisionStay-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onCollisionExit(IntPtr l) {
		try {
			EventListener self=(EventListener)checkSelf(l);
			EventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onCollisionExit=v;
			else if(op==1) self.onCollisionExit+=v;
			else if(op==2) self.onCollisionExit-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"EventListener");
		addMember(l,OnPointerClick);
		addMember(l,OnPointerDown);
		addMember(l,OnPointerEnter);
		addMember(l,OnPointerExit);
		addMember(l,OnPointerUp);
		addMember(l,OnSelect);
		addMember(l,OnSubmit);
		addMember(l,Get_s);
		addMember(l,"onClick",null,set_onClick,true);
		addMember(l,"onDown",null,set_onDown,true);
		addMember(l,"onEnter",null,set_onEnter,true);
		addMember(l,"onExit",null,set_onExit,true);
		addMember(l,"onUp",null,set_onUp,true);
		addMember(l,"onSelect",null,set_onSelect,true);
		addMember(l,"onUpdateSelect",null,set_onUpdateSelect,true);
		addMember(l,"onSubmit",null,set_onSubmit,true);
		addMember(l,"onTriggerEnter",null,set_onTriggerEnter,true);
		addMember(l,"onTriggerStay",null,set_onTriggerStay,true);
		addMember(l,"onTriggerExit",null,set_onTriggerExit,true);
		addMember(l,"onCollisionEnter",null,set_onCollisionEnter,true);
		addMember(l,"onCollisionStay",null,set_onCollisionStay,true);
		addMember(l,"onCollisionExit",null,set_onCollisionExit,true);
		createTypeMetatable(l,null, typeof(EventListener),typeof(UnityEngine.MonoBehaviour));
	}
}
