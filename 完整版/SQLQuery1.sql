use SuDaExpress
select * from admin
select count(1) from admin where AdmUid = 123 and AdmPwd = 'qwe'
insert admin values(123,'qwe')
select * from [user]
select * from UserExpressXinXI
select * from staff
select * from KuaiDiBaoShi
select * from TouSuKaiDi
select b.UserUid,ShouHuoRenName,ShouHuoAddress,ShouHuoRenPhone,YouDiRenName,YouDiAddress,YouDiRenPhone,b.Odd,LanJianTime,LiuYan ,q.ShuoMing,StaffNo,KuaiDiMoney
from KuaiDiBaoShi as a
inner join UserExpressXinXI as b
on a.Odd=b.Odd 
inner join QianShou as q
on QianShou = q.BiaoShi
where b.Odd like '%{0}%'
delete from KuaiDiBaoShi where Odd = 1005
select t.UserUid,ShouHuoRenName,ShouHuoAddress,ShouHuoRenPhone,YouDiRenName,YouDiAddress,YouDiRenPhone,t.Odd,LanJianTime,LiuYan ,q.ShuoMing,StaffNo,KuaiDiMoney,t.TouSuYuanYin
from TouSuKaiDi as t
inner join UserExpressXinXI as b
on t.Odd=b.Odd 
inner join QianShou as q
on QianShou = q.BiaoShi
--select DATEPART(m,CZTime) as 月份,sum(CZMoney) as 总金额 from [VIPChongzhi]   group by DATEPART(m,CZTime)
--select VIPId,CZTime,CZMoney,Name from  VIPChongzhi,Jie where Jie.Id=VIPChongzhi.Fangshi  and CZTime between '{0}' and '{1}'", kaiTime, daoTime
--select sum(CZMoney) from VIPChongzhi where  CZTime between '{0}' and '{1}'", kaiTime, daoTime
--select count(shouhuoaddress) from UserExpressXinXI 
--select * from UserExpressXinXI
--select count(*) from UserExpressXinXI between '2019/1/1' and '2019/2/18'
--select DATEPART(m,LanJianTime)
select * from UserExpressXinXI where LanJianTime between 1905-07-12 and 2019-02-19
select ComName , ComText , ComMoney
from TiaoZaoWoDeKuaiDi as w
inner join CommodityTable as c
on w.UserUid = c.UserUid
where w.UserUid = 200001