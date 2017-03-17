--¼Ì³Ð×ÔStateÀà
local State = require("rpgdemo/Fsm/State")

local AttackState = State:new{

monster,
anim,

simpleAi

}

function AttackState:Init(stateid,fsm,monster)
	State.Init(self,stateid,fsm)
	self.monster = monster
	self.anim = self.monster.gameObject:GetComponent("Animator")	
	self.simpleAi = self.monster.simpleAi
end

function AttackState:Enter()
	API.Log(self.stateId)
	if self.monster.actTarget == nil then 
		self.mFSM.ChangeState(StateEnum.IDLE)
	end
	
	if self.anim ~= nil then
		self.anim:SetInteger("AIState",0)
	end
end

function AttackState:Excute()
	self.monster.transform:LookAt(self.monster.actTarget.transform)
	
	if self.simpleAi.dis <= self.monster.actRange then
		self.simpleAi.FindEnemy()
		if((Time.time - self.simpleAi.lastAttackTime) >= self.monster.attackIntervalTime) then
			self.anim:SetInteger("AIState" ,1)
			
			self.monster:Attack()
			
			local animInfo = self.anim:GetCurrentAnimatorStateInfo(0)
			if animInfo:IsName("GoblinAttack") and animInfo.normalizedTime >= 1 then
			
				self.anim:SetInteger("AIState", 0);
			end
			self.simpleAi.lastAttackTime = Time.time;
		end
	else
		self.mFSM.ChangeState(StateEnum.FOLLOW)	 
	end
end

function AttackState:Exit()
	
end

return AttackState