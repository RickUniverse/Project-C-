use XiYiDian
select * from ShouQuYiFu
insert into ShouQuYiFu values('李四','1000423','1001','是','2010-1-1','1','123','123','无')
select * from DingDanXiangXi
insert into DingDanXiangXi values(1048,'34',2,4,1,2,'2010-1-1','无','无','0','')

select * from HuiYuan

select * from ShouQuYiFu as sqyf
--会员--
inner join HuiYuan as hy
on hy.HuiYuanID = sqyf.HuiYuan
--会员种类
inner join HuiYuanZhongLei as hyzl
on hyzl.HuiYuanZhongLeiID = hy.ZhongLei
--会员状态
inner join HuiYuanZhuangTai as hyzt
on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai 
--会员时间
inner join HuiYuanTime as hytime
on hytime.ShiJianID = hy.ShiJian
--订单详细--
inner join DingDanXiangXi as ddxx
on ddxx.SuoShuDingDan = sqyf.ShouQuYiFuID
--洗衣方式
inner join XiYiFangShi as xyfs
on xyfs.LeiXingID = ddxx.XiFangShi
--衣服种类
inner join YiFuZhongLei as yfzl
on yfzl.YiFuZhongLeiID = ddxx.YiFuZhongLei
--衣服状态
inner join YiFuZhuangTai as yfzt
on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai
--衣服颜色
inner join YiFuYanSe as yfys
on yfys.YanSeID = ddxx.YanSe

where sqyf.ShouQuYiFuID = 1048
select * from ShouQuYiFu as sqyf
--会员--
inner join HuiYuan as hy
on hy.HuiYuanID = sqyf.HuiYuan
--会员种类
inner join HuiYuanZhongLei as hyzl
on hyzl.HuiYuanZhongLeiID = hy.ZhongLei
--会员状态
inner join HuiYuanZhuangTai as hyzt
on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai 
--会员时间
inner join HuiYuanTime as hytime
on hytime.ShiJianID = hy.ShiJian
where sqyf.ShouQuYiFuID = 1048


select * from ShouQuYiFu as sqyf
--订单详细--
inner join DingDanXiangXi as ddxx
on ddxx.SuoShuDingDan = sqyf.ShouQuYiFuID
--洗衣方式
inner join XiYiFangShi as xyfs
on xyfs.LeiXingID = ddxx.XiFangShi
--衣服种类
inner join YiFuZhongLei as yfzl
on yfzl.YiFuZhongLeiID = ddxx.YiFuZhongLei
--衣服状态
inner join YiFuZhuangTai as yfzt
on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai
--衣服颜色
inner join YiFuYanSe as yfys
on yfys.YanSeID = ddxx.YanSe
where sqyf.ShouQuYiFuID = 1048


--取衣服会员--
select * from ShouQuYiFu as sqyf
inner join HuiYuan as hy
on hy.HuiYuanID = sqyf.HuiYuan
inner join HuiYuanZhongLei as hyzl
on hyzl.HuiYuanZhongLeiID = hy.ZhongLei
inner join HuiYuanZhuangTai as hyzt
on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai 
inner join HuiYuanTime as hytime
on hytime.ShiJianID = hy.ShiJian
where hy.HuiYuanID like '%1001%' or hy.HuiYuanRenName like '%{tex_cha.Text}%'
where sqyf.ShouQuYiFuID = 1048

--订单详细
select * from ShouQuYiFu as sqyf
inner join DingDanXiangXi as ddxx
on ddxx.SuoShuDingDan = sqyf.ShouQuYiFuID
inner join XiYiFangShi as xyfs
on xyfs.LeiXingID = ddxx.XiFangShi
inner join YiFuZhongLei as yfzl
on yfzl.YiFuZhongLeiID = ddxx.YiFuZhongLei
inner join YiFuYanSe as yfys
on yfys.YanSeID = ddxx.YanSe
inner join YiFuZhuangTai as yfzt
on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai
inner join HuiYuan as hy
on hy.HuiYuanID = sqyf.HuiYuan
where hy.HuiYuanID = 1001

--会员--
select * from HuiYuan as hy
inner join HuiYuanZhongLei as hyzl
on hyzl.HuiYuanZhongLeiID = hy.ZhongLei
inner join HuiYuanZhuangTai as hyzt
on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai 
inner join HuiYuanTime as hytime
on hytime.ShiJianID = hy.ShiJian
where NowTime >= '2010-1-1' and NowTime <= '2019-1-1'
select * from ShouQuYiFu  order by ShouQuYiFuID desc

select * from ShouQuYiFu as sqyf
inner join HuiYuan as hy
on hy.HuiYuanID = sqyf.HuiYuan
inner join DingDanZhuangTai as ddzt
on ddzt.DingDanZhuangTai = sqyf.DingDanZhuangTai
where sqyf.ShouQuTime >= '2010-1-1' and sqyf.ShouQuTime <= '2019-1-1'


where sqyf.lianXiDianHua like '%423%' or hy.HuiYuanID like '%423%' or hy.HuiYuanRenName like '%%' or sqyf.ShouQuYiFuID like '%423%'
update ShouQuYiFu set YingShouJinE = 11 ,ShiShouJinE = 1 where ShouQuYiFuID = 1050

select * from DingDanXiangXi as ddxx
inner join ShouQuYiFu as sqyf
on sqyf.ShouQuYiFuID = ddxx.SuoShuDingDan
inner join XiYiFangShi as xyfs
on xyfs.LeiXingID = ddxx.XiFangShi
inner join YiFuZhongLei as yfzl
on yfzl.YiFuZhongLeiID = ddxx.YiFuZhongLei
inner join YiFuZhuangTai as yfzt
on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai
inner join YiFuYanSe as yfys
on yfys.YanSeID = ddxx.YanSe
where ddxx.SuoShuDingDan = 1063 and YiFuZhuangTaiID = 3
select * from ShouQuYiFu as sqyf inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan inner join DingDanZhuangTai as ddzt on ddzt.DingDanZhuangTai = sqyf.DingDanZhuangTai
inner join HuiYuanZhuangTai as hyzt
on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai

select * from DingDanXiangXi as ddxx
inner join ShouQuYiFu as sqyf
on sqyf.ShouQuYiFuID = ddxx.SuoShuDingDan
inner join HuiYuan as hy
on hy.HuiYuanID = sqyf.HuiYuan
inner join HuiYuanZhuangTai as hyzt
on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai 
inner join YiFuZhuangTai as yfzt
on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai
inner join XiYiFangShi as xyfs
on xyfs.LeiXingID = ddxx.XiFangShi
inner join YiFuZhongLei as yfzl
on yfzl.YiFuZhongLeiID = ddxx.YiFuZhongLei
inner join YiFuYanSe as yfys
on yfys.YanSeID = ddxx.YanSe
where yfzt.YiFuZhuangTaiID = 3

update ShouQuYiFu set ShuLiang = 6 where ShouQuYiFuID = 1063
select * from DingDanXiangXi as ddxx
inner join ShouQuYiFu as sqyf
on sqyf.ShouQuYiFuID = ddxx.SuoShuDingDan
inner join YiFuZhuangTai as yfzt
on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai
where sqyf.ShouQuYiFuID = 1062 and ddxx.YiFuZhuangTai = 2 or ddxx.YiFuZhuangTai = 6


update ShouQuYiFu set ShuLiang = 6 where ShouQuYiFuID = 1
update DingDanXiangXi set YiFuZhuangTai = 5 ,QuYiTime = '' where YiFuBianHao = 1

select * from HuiYuan as hy
inner join ChongZhiJiLu as czjl
on czjl.HuiYuanId = hy.HuiYuanID
where hy.HuiYuanID = 1001