--��ȡȫ�ֱ���player��Ȼ������������
local CameraController = {}

local heroPos
local cameraPos
local distance = 6.5
local height = 4.2
local rotation
local xAngle
local yAngle
local xMouseMoveSpeed = 5

function CameraController.Start()
	this=CameraController.this	
	
	heroPos = player.gameObject.transform
	cameraPos = Camera.main.transform
	--�ȸ���player��λ�ó�ʼ���������λ��
	CameraController.ResetCamera()
		
	this.usingLateUpdate=true
end

function CameraController.ResetCamera()
	cameraPos.rotation = heroPos.rotation
	local pos = heroPos.forward * (-distance) + 
				heroPos.position +
				Vector3(0,height,0)
	cameraPos.position = pos;
	cameraPos:LookAt(heroPos.position + Vector3(0, height, 0));

	rotation = cameraPos.rotation;
	xAngle = rotation.eulerAngles.x;
	yAngle = rotation.eulerAngles.y;
	
end
--�����λ�ô�����LateUpdate����
function CameraController.LateUpdate()
	
	if cameraPos == nil then
		cameraPos = Camera.main.transform
	end

	if (Input.GetMouseButton(0) or Input.GetMouseButton(1)) then
		local mouseX = Input.GetAxis("Mouse X") * xMouseMoveSpeed
		local mouseY = Input.GetAxis("Mouse Y")

		xAngle = xAngle - mouseY;
		yAngle = yAngle + mouseX;
		rotation = Quaternion.Euler(xAngle, yAngle, 0);
	end
	
	if (Input.GetMouseButtonUp(1)) then
        
		heroPos.rotation = Quaternion.Euler(0, yAngle + heroPos.eulerAngles.y, 0)
		xAngle = 0
		yAngle = 0
		rotation = Quaternion.Euler(xAngle, yAngle, 0);
	
	end
	cameraPos.position = rotation * heroPos.forward * -distance + (heroPos.position + Vector3(0, height, 0));
	
	cameraPos:LookAt(heroPos.position + Vector3(0, height - 1.5, 0));

        
       
	
	
end






return CameraController