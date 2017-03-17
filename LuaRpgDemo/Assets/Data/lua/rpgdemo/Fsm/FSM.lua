--有限状态机
local FSM = {}

local FSMStatesDic = {}
local mCurrent
local mPrevious

local mEntity

local IDLE = "idle"
local PATROL = "patrol"
local ALERT = "alert"	
local FOLLOW = "follow"	
local ATTACK = "attack"	
local FLEE = "flee"
local DEAD = "dead" 	

local AlertState = require("rpgdemo/FSM/AlertState")
local IdleState = require("rpgdemo/FSM/IdleState")
local AttackState = require("rpgdemo/FSM/AttackState")
local DeadState = require("rpgdemo/FSM/DeadState")
local FollowState = require("rpgdemo/FSM/FollowState")

function FSM.Start()

	this=FSM.this
	transform=FSM.transform
	gameObject=FSM.gameObject	
	
	
	
end


function FSM.initEntity(entity)
	--monster的lua脚本
	mEntity = entity
	
	local alertstate = AlertState:new()
	alertstate:Init(ALERT,FSM,mEntity)
	FSMStatesDic[ALERT] = alertstate
	
	local idlestate = IdleState:new()
	idlestate:Init(IDLE,FSM,mEntity)
	FSMStatesDic[IDLE] = idlestate
	
	local attackstate = AttackState:new()
	attackstate:Init(ATTACK,FSM,mEntity)
	FSMStatesDic[ATTACK] = attackstate
	
	local deadstate = DeadState:new()
	deadstate:Init(DEAD,FSM,mEntity)
	FSMStatesDic[DEAD] = deadstate
	
	local followkstate = FollowState:new()
	followkstate:Init(FOLLOW,FSM,mEntity)
	FSMStatesDic[FOLLOW] = followkstate
	
	this.usingUpdate = true
	
end

function FSM.ChangeState(stateId)
	
	if(mCurrent ~= nil and stateId == mCurrent.stateId) then
		mCurrent:Refresh()
		return
	end
	
	local state = FSMStatesDic[stateId]
	if(state ~= nil) then
		FSM.SwitchState(state)
	end
	
end

function FSM.SwitchState(state)
	
	if(mCurrent ~= nil) then
		mCurrent:Exit()
	end
	
	mPrevious = mCurrent
	mCurrent = state
	mCurrent:Enter()
	
end

function FSM.Update(state)
	
	if(mCurrent ~= nil) then
		mCurrent:Excute()
	end	
	
end

return FSM