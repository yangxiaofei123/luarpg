local GameUtils = {}

function GameUtils.getDistance(obj,target)
	return Vector3.Distance(obj.transform.position,target.transform.position)
end

--�������Ļ��ѡȡ���еĹ���
function GameUtils.mouseClickFindTarget()
	
	local ray = Camera.main:ScreenPointToRay(Input.mousePosition)
	local ok, hit = Physics.Raycast(ray,Slua.out,100)
	print(ok)
	if(ok) then
		local hitObj = hit.collider.gameObject
		return GameUtils.getLuaByName(hitObj,"Monster")
	end
	return nil
end
--��鵱ǰ���GameObject�ǲ���һ������
function GameUtils.checkLuaName(go,name)
	
	local goArray = go:GetComponents("LuaBehaviour")
		
	for v in Slua.iter(goArray) do		
		if v.LuaName == name then			
			return true
		end
	end
	
	return false
end
--�������ֻ�ȡ�󶨵�lua�ű�
function GameUtils.getLuaByName(go,name)
	
	local goArray = go:GetComponents("LuaBehaviour")
	
	for v in Slua.iter(goArray) do		
		if v.LuaName == name then			
			return v:GetChunk()
		end
	end
	
	return nil
end

--������ײ���ռ���ҵĹ����Tab�Զ�ѡȡ��������ʹ��
function GameUtils.tabFindTarget()
	return nil
end

function GameUtils.table_maxn(t)
    local mn = 0
    for k, v in pairs(t) do
        if mn < k then
            mn = k
        end
    end
    return mn
end


return GameUtils