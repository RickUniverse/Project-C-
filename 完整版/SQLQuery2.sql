use SuDaExpress
select * from UserExpressXinXI
update UserExpressXinXI set ShouHuoAddress = '北京朝阳区金橘街' ,  NowAddress = '河北邯郸肥乡' where Odd = 10000001
select count(*) from [user] where useruid = 200001 and userpwd = 'qwerty'
select count(*) from UserExpressXinXI
update [user] set UserPwd = 'qwerty' , Name = '啊' 
select * from [CommodityTable] where ComName like '%e%'
select w.UserUid , q.ShuoMing , w.UserAdd ,YouDiRenPhone ,StaffNo
from TiaoZaoWoDeKuaiDi as w
inner join UserExpressXinXI as x
on w.UserAdd = x.Odd
inner join QianShou as q
on q.BiaoShi = x.QianShou

select count(*) from UserExpressXinXI where QianShou = 2 and Odd = 10000018

select StaffNo
from TiaoZaoWoDeKuaiDi as w
inner join UserExpressXinXI as x
on w.UserAdd = x.Odd
