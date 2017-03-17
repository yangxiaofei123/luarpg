
--�ȴ�main.lua���洴��GameMain���GameObject��Ȼ�������GameMain�ϰ�LuaBehavior��ִ�д�lua�ű���
--����ű���rpg��Ϸ����ڣ�Ҳ����Ϸȫ�ֵĹ����࣬�����ִ�г�ʼ����ɫ����ͼ��UI��
--GameMain�Ǹ��ֲ���table
local GameMain={}

--Lua�еı�����������ʱ����븳ֵ��
local player = nil

local mainGameObject
--��ʼ��һ��ȫ�ֱ��������enum�Ĺ���
StateEnum = require("rpgdemo/Util/StateEnum")
SkillStateEnum = require("rpgdemo/Util/SkillStateEnum")
GameUtils = require("rpgdemo/Util/GameUtils")

--��LuaBehavior����ִ��DoFile lua�ű��ɹ��󣬾Ϳ�ʼִ��Start������
function GameMain.Start()
	
	--this��LuaBehavior��Ķ���Ҳ����MonoBehavior��this������transform��gameObject��
	--������ͨ��LuaBehavior��SetEnv��������ȫ�ֱ���_G��������ǵ�ǰ�����Luatable�ű����������
	this=GameMain.this
	mainGameObject = GameMain.gameObject
	
	GameMain.Init()
	
end

--��ʼ����ɫ��UI����ͼ
function GameMain.Init()
	
	--��ʼ��Ӣ��
	--Slua��֧�ַ��͡�����д��������Resources.Load<GameObject>
	local playerGO = GameObject.Instantiate(Resources.Load("prefabs/Hero/Hero"))
	playerGO.name = "Player"
	local lbhero = API.AddComponent(playerGO,"LuaBehaviour")
	lbhero:DoFile("rpgdemo/Role/Hero",function()
		
		--���Լ̳�lua�ű�
		local hero_script=lbhero:GetChunk()	
		player = hero_script
 		--API.Log("ss"..hero_script.maxMp)
		--��player����Ϊȫ�ֱ��������������ű����ʣ�֮������취
		--�ô��ݲ����ķ�ʽ��
		lbhero:SetEnv("player",player,true)
		
	end)
	
	--���������ƽű�
	local lbMove = API.AddComponent(playerGO,"LuaBehaviour")
	lbMove:DoFile("rpgdemo/Action/HeroMove",function()			
		
	end)
	
	--�������Ķ���
	local lbAnim = API.AddComponent(playerGO,"LuaBehaviour")
	lbAnim:DoFile("rpgdemo/Action/HeroAnimatorController",function()			
		
	end)
	
	--������������ű�
	local lbcamera = API.AddComponent(playerGO,"LuaBehaviour")
	lbcamera:DoFile("rpgdemo/Action/CameraController",function()			
		
	end)
	
	--��Ӽ���ϵͳ
	local lbSkill = API.AddComponent(playerGO,"LuaBehaviour")
	lbSkill:DoFile("rpgdemo/Skill/SkillSystem",function()			
		local skill_script=lbSkill:GetChunk()	
		
		player.skillSystem = skill_script
	end)
	
	--��ʼ��UI
	local ui = GameObject.Instantiate(Resources.Load("prefabs/UI/PlayerUI"))
	ui.name = "GameUI"
	
	local lbSkillUI = API.AddComponent(ui,"LuaBehaviour")
	lbSkillUI:DoFile("rpgdemo/UI/SkillUI",function()			
		
	end)
	
	local lbSkillUI = API.AddComponent(ui,"LuaBehaviour")
	lbSkillUI:DoFile("rpgdemo/UI/PlayerStateUI",function()			
		
	end)
	
	GameObject.DontDestroyOnLoad(playerGO)
	GameObject.DontDestroyOnLoad(ui)
	GameObject.DontDestroyOnLoad(mainGameObject)
	
	--��ͼ����ϵͳ��ʼ��
	GameMain.InitMapSystem()
	
end

function GameMain.InitMapSystem()
	
	--��ʼ����ͼϵͳ
	local lb = API.AddComponent(mainGameObject,"LuaBehaviour")
	lb:DoFile("rpgdemo/MapSystem",function()
		
		--��ȡ�󶨵�lua�ű�
		local map_script=lb:GetChunk()	
			
		--��Ӣ�۸���MapSystem,1.ͨ��LuaBehavior�ķ������󶨵Ľű���
		--��ֵӢ�۵����ã�Ȼ�����Lua�ű�����ķ�����2.playerֱ�Ӿ��Ǹ�ȫ�ֱ�����
		--���ﾡ������ȫ�ֱ���������player��GameMain����ͨ���������ݸ�MapSystem
--		lb:SetEnv("player",player,false)
		map_script.InitPlayerPos()
	end)
	
	
	
	
	--�����һ�ŵ�ͼ
	SceneManagement.SceneManager.LoadScene(2)
end

--����Ҫreturn ���lua�ű���Ҫ���������Լ���õķ���������start
return GameMain