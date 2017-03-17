--��ȡ������ϵ�CharacterController��Ȼ��������
local HeroMove = {}
local charController = nil
local this
local gameObject
local transform
local moveX = 0
local moveZ = 0
local moveDirection
local turnSpeed = 90

--��LuaBehavior.DoFile֮���ڵ���complete��ʱ���Ѿ���Startִ�������
function HeroMove.Start()
	--���Ȱ�Mono��this�ȳ��ñ�������������
	this=HeroMove.this
	transform=HeroMove.transform
	gameObject=HeroMove.gameObject
	
	--��ȡCharacterController
	charController = this:GetComponent("CharacterController")
	moveDirection = player.transform.forward 
	
	
	this.usingUpdate=true
end

function HeroMove.Update()
	
	if charController.isGrounded then
		
		moveX = Input.GetAxis("Horizontal")
		moveZ = Input.GetAxis("Vertical")
		moveDirection = Vector3(0, 0, moveZ);
		if moveZ < 0 then
			moveDirection = moveDirection * (player.speed / 2)
		else
			moveDirection = moveDirection * player.speed
		end
		
		if( Input.GetButton("Jump")) then
			player.isDaZuo = false
			moveDirection.y = player.jumpSpeed
		end
		
		if(moveZ ~= 0) then
		player.isDaZuo = false
		end
		
		moveDirection = transform:TransformDirection(moveDirection)
		
		
	end 
	
	moveDirection.y = moveDirection.y - player.gravity* Time.deltaTime
	
	if(moveX > 0) then
		transform:Rotate(transform.up * turnSpeed * Time.deltaTime)
	elseif(moveX < 0) then
		transform:Rotate(transform.up * -turnSpeed * Time.deltaTime)
	end
	
	charController:Move(moveDirection * Time.deltaTime)
end

return HeroMove