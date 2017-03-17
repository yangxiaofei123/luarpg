local HeroAnimatorController = {}

local anim
local charController
local animInfo
local heroMove
local hero

local moveSpeed = Animator.StringToHash("moveSpeed");
local isJump = Animator.StringToHash("isJump");
local isFighting = Animator.StringToHash("isFighting");
local isDeath = Animator.StringToHash("isDeath");
local isBeAttack = Animator.StringToHash("isBeAttack");

local inputVal
local moveX
local moveZ

local jumpTime

function HeroAnimatorController.Start()
	
	this=HeroAnimatorController.this
	transform=HeroAnimatorController.transform
	gameObject=HeroAnimatorController.gameObject
	
	hero = player
	anim = this:GetComponent("Animator")
	charController = this:GetComponent("CharacterController")
	
	this.usingUpdate=true
	
end 

function HeroAnimatorController.Update()
	
	HeroAnimatorController.animToMove()
	HeroAnimatorController.animToJump()

	local b = player.isFighting
		
	anim:SetBool(isFighting,b)
	
end

function HeroAnimatorController.animToMove()
	
	moveX = Input.GetAxis("Horizontal");
    moveZ = Input.GetAxis("Vertical");

	anim:SetFloat(moveSpeed, moveZ);
	
end

function HeroAnimatorController.animToJump()
	
	if Input.GetButton("Jump") then
		jumpTime = Time.time
		anim:SetBool(isJump, true)
	end
	
	if(anim:GetBool(isJump)) then
		if charController.isGrounded or Time.time - jumpTime >= 1.5 then
			anim:SetBool(isJump ,false)
		end
	end
	
end

function HeroAnimatorController.AttackActionEnd()
	
	animInfo = anim:GetCurrentAnimatorStateInfo(0)
	
	if animInfo.normalizedTime >= 1 and animInfo.IsTag("AttackAction") then
		
	end
end

return HeroAnimatorController