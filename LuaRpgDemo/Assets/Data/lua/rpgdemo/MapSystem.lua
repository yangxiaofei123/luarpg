--��ͼϵͳ�������ͼ�����ı任�����������
local MapSystem = {}


--��LuaBehavior.DoFile֮���ڵ���complete��ʱ���Ѿ���Startִ�������
function MapSystem.Start()
	
	--��ʼ����һ�ŵ�ͼ
	
	MapSystem.InitMonsters()
	
	
end

function MapSystem.InitPlayerPos()
	
	player.transform.position = Vector3(203,0,165)	
	
end

function MapSystem.InitMonsters()
	
	local monsterGO = GameObject.Instantiate(Resources.Load("prefabs/Monster/Goblin"))
	monsterGO.name = "monster"
	monsterGO.transform.position = Vector3(203,0,180)
	local lbmonster = API.AddComponent(monsterGO,"LuaBehaviour")
	lbmonster:DoFile("rpgdemo/Role/Monster",function()
		
		local monster_script=lbmonster:GetChunk()	
		
		
	end)
	
		
	local monsterGO1 = GameObject.Instantiate(Resources.Load("prefabs/Monster/Goblin"))
	monsterGO1.name = "monster1"
	monsterGO1.transform.position = Vector3(188,0,180)
	local lbmonster1 = API.AddComponent(monsterGO1,"LuaBehaviour")
	lbmonster1:DoFile("rpgdemo/Role/Monster",function()
		
		local monster_script=lbmonster1:GetChunk()			
		
	end)
	
end

return MapSystem
















