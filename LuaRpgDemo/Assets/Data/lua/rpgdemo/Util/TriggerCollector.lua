--�����Χ�����ռ���
local TriggerCollector = {}
--���������洢�����Χ�Ĺ�����
TriggerCollector.collObjList = {}

--��LuaBehavior.DoFile֮���ڵ���complete��ʱ���Ѿ���Startִ�������
function TriggerCollector.Start()
	--���Ȱ�Mono��this�ȳ��ñ�������������
	this=TriggerCollector.this
	transform=TriggerCollector.transform
	gameObject=TriggerCollector.gameObject
	
	EventListener.Get(gameObject).onTriggerEnter=TriggerCollector.OnTriggerEnter
	EventListener.Get(gameObject).onTriggerExit=TriggerCollector.OnTriggerExit	
	
	this.usingUpdate=true
end

function TriggerCollector.Update()
	if GameUtils.table_maxn(TriggerCollector.collObjList) == 0 then
		return
	end
	for k,v in ipairs(TriggerCollector.collObjList) do
		if TriggerCollector.collObjList[k]:isLive() == false then
			table.remove(TriggerCollector.collObjList,k)
		end
	end
end

function TriggerCollector.OnTriggerEnter(collider)
	local luascript = GameUtils.getLuaByName(collider.gameObject,"Monster")
	if luascript ~= nil and luascript:isLive() then
		table.insert(TriggerCollector.collObjList,luascript)
	end
end

function TriggerCollector.OnTriggerExit(collider)
	local luascript = GameUtils.getLuaByName(collider.gameObject,"Monster")
	for k,v in ipairs(TriggerCollector.collObjList) do
		if TriggerCollector.collObjList[k] == luascript then
			table.remove(TriggerCollector.collObjList,k)
		end
	end
end


function TriggerCollector.GetTriggerObj()
	local length = GameUtils.table_maxn(TriggerCollector.collObjList)
	if length > 0 then
		local idx=math.floor(length * math.random())+1
		return TriggerCollector.collObjList[idx]	
	end
	return nil
end


return TriggerCollector