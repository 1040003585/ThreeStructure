
use hd_wast_1
go
-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Samples_reason_Add

@bh varchar(18),
@sample_id varchar(18)=null,
@component_id varchar(18)=null,
@component_name varchar(80)=null,
@result tinyint,
@reason varchar(120)=null,
@edit_name varchar(12)=null,
@edit_date datetime=null,
@jc_result decimal=null,
@resut varchar(50)=null

AS
BEGIN
	insert into Samples_reason values(@bh,@sample_id,@component_id,@component_name,@result,@reason,@edit_name,@edit_date,@jc_result,@resut)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Samples_reason_Delete

@bh varchar(18)

AS
BEGIN
	delete from Samples_reason where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Samples_reason_Change

@bh varchar(18),
@sample_id varchar(18)=null,
@component_id varchar(18)=null,
@component_name varchar(80)=null,
@result tinyint,
@reason varchar(120)=null,
@edit_name varchar(12)=null,
@edit_date datetime=null,
@jc_result decimal=null,
@resut varchar(50)=null

AS
BEGIN
	update Samples_reason set sample_id=@sample_id,component_id=@component_id,component_name=@component_name,result=@result,reason=@reason,edit_name=@edit_name,edit_date=@edit_date,jc_result=@jc_result,resut=@resut where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_reason_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Samples_reason where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_reason_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Samples_reason'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_reason_SelectAll
AS
BEGIN
	select * from Samples_reason
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Container_pc_Add

@container_id varchar(18),
@rq datetime=null,
@import_rq datetime=null,
@user_id varchar(18)=null,
@bz tinyint=null

AS
BEGIN
	insert into Container_pc values(@container_id,@rq,@import_rq,@user_id,@bz)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Container_pc_Delete

@container_id varchar(18)

AS
BEGIN
	delete from Container_pc where container_id=@container_id
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Container_pc_Change

@container_id varchar(18),
@rq datetime=null,
@import_rq datetime=null,
@user_id varchar(18)=null,
@bz tinyint=null

AS
BEGIN
	update Container_pc set rq=@rq,import_rq=@import_rq,user_id=@user_id,bz=@bz where container_id=@container_id
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Container_pc_SelectById

@container_id varchar(18)

AS
BEGIN
	select * from Container_pc where container_id=@container_id
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Container_pc_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Container_pc'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Container_pc_SelectAll
AS
BEGIN
	select * from Container_pc
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Wast_Add

@bh varchar(18)=null,
@customer_num varchar(18),
@waste_id varchar(18),
@sample_id varchar(18)=null,
@waste_name varchar(50)=null,
@waste_code varchar(18)=null,
@process_code varchar(18)=null,
@hazard_code varchar(18)=null,
@treatment_flow varchar(18)=null,
@treatment_rate decimal=null,
@sample_date datetime=null,
@approval_date datetime=null,
@approved_by varchar(16)=null,
@remark varchar(120)=null,
@precaution varchar(100)=null,
@ytd_vol decimal=null,
@atc_vol decimal=null,
@created_by varchar(16)=null,
@create_date datetime=null,
@updated_by varchar(16)=null,
@update_date datetime=null,
@other_fee decimal=null,
@charging_fee decimal=null,
@treatment_1 tinyint=null,
@treatment_2 tinyint=null,
@treatment_3 tinyint=null,
@treatment_4 tinyint=null,
@treatment_other tinyint=null,
@type_1 tinyint=null,
@type_2 tinyint=null,
@type_3 tinyint=null,
@type_4 tinyint=null,
@type_5 tinyint=null,
@type_other tinyint=null,
@xt_1 tinyint=null,
@xt_2 tinyint=null,
@xt_3 tinyint=null,
@out_1 tinyint=null,
@out_2 tinyint=null,
@out_3 tinyint=null,
@bzfs varchar(100)=null,
@zycf varchar(100)=null,
@stutas char(2)=null,
@ht_bm varchar(30)=null,
@color varchar(20)=null,
@is_cy tinyint=null,
@fwcs_bh char(22)=null,
@sc_fzr varchar(18)=null,
@zx_bh varchar(20)=null,
@xt_4 tinyint=null,
@cf_1 tinyint=null,
@cf_2 tinyint=null,
@cf_3 tinyint=null,
@cf_4 tinyint=null,
@cf_5 tinyint=null,
@cf_6 tinyint=null,
@cf_7 tinyint=null,
@cf_8 tinyint=null,
@jy_1 tinyint=null,
@jy_2 tinyint=null,
@reason varchar(80)=null,
@waste_bzfs varchar(100)=null,
@waste_ysfs varchar(100)=null,
@unsh tinyint=null,
@unshr varchar(18)=null,
@unshrq datetime=null

AS
BEGIN
	insert into Wast values(@bh,@customer_num,@waste_id,@sample_id,@waste_name,@waste_code,@process_code,@hazard_code,@treatment_flow,@treatment_rate,@sample_date,@approval_date,@approved_by,@remark,@precaution,@ytd_vol,@atc_vol,@created_by,@create_date,@updated_by,@update_date,@other_fee,@charging_fee,@treatment_1,@treatment_2,@treatment_3,@treatment_4,@treatment_other,@type_1,@type_2,@type_3,@type_4,@type_5,@type_other,@xt_1,@xt_2,@xt_3,@out_1,@out_2,@out_3,@bzfs,@zycf,@stutas,@ht_bm,@color,@is_cy,@fwcs_bh,@sc_fzr,@zx_bh,@xt_4,@cf_1,@cf_2,@cf_3,@cf_4,@cf_5,@cf_6,@cf_7,@cf_8,@jy_1,@jy_2,@reason,@waste_bzfs,@waste_ysfs,@unsh,@unshr,@unshrq)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Wast_Delete

@bh varchar(18)

AS
BEGIN
	delete from Wast where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Wast_Change

@bh varchar(18)=null,
@customer_num varchar(18),
@waste_id varchar(18),
@sample_id varchar(18)=null,
@waste_name varchar(50)=null,
@waste_code varchar(18)=null,
@process_code varchar(18)=null,
@hazard_code varchar(18)=null,
@treatment_flow varchar(18)=null,
@treatment_rate decimal=null,
@sample_date datetime=null,
@approval_date datetime=null,
@approved_by varchar(16)=null,
@remark varchar(120)=null,
@precaution varchar(100)=null,
@ytd_vol decimal=null,
@atc_vol decimal=null,
@created_by varchar(16)=null,
@create_date datetime=null,
@updated_by varchar(16)=null,
@update_date datetime=null,
@other_fee decimal=null,
@charging_fee decimal=null,
@treatment_1 tinyint=null,
@treatment_2 tinyint=null,
@treatment_3 tinyint=null,
@treatment_4 tinyint=null,
@treatment_other tinyint=null,
@type_1 tinyint=null,
@type_2 tinyint=null,
@type_3 tinyint=null,
@type_4 tinyint=null,
@type_5 tinyint=null,
@type_other tinyint=null,
@xt_1 tinyint=null,
@xt_2 tinyint=null,
@xt_3 tinyint=null,
@out_1 tinyint=null,
@out_2 tinyint=null,
@out_3 tinyint=null,
@bzfs varchar(100)=null,
@zycf varchar(100)=null,
@stutas char(2)=null,
@ht_bm varchar(30)=null,
@color varchar(20)=null,
@is_cy tinyint=null,
@fwcs_bh char(22)=null,
@sc_fzr varchar(18)=null,
@zx_bh varchar(20)=null,
@xt_4 tinyint=null,
@cf_1 tinyint=null,
@cf_2 tinyint=null,
@cf_3 tinyint=null,
@cf_4 tinyint=null,
@cf_5 tinyint=null,
@cf_6 tinyint=null,
@cf_7 tinyint=null,
@cf_8 tinyint=null,
@jy_1 tinyint=null,
@jy_2 tinyint=null,
@reason varchar(80)=null,
@waste_bzfs varchar(100)=null,
@waste_ysfs varchar(100)=null,
@unsh tinyint=null,
@unshr varchar(18)=null,
@unshrq datetime=null

AS
BEGIN
	update Wast set customer_num=@customer_num,waste_id=@waste_id,sample_id=@sample_id,waste_name=@waste_name,waste_code=@waste_code,process_code=@process_code,hazard_code=@hazard_code,treatment_flow=@treatment_flow,treatment_rate=@treatment_rate,sample_date=@sample_date,approval_date=@approval_date,approved_by=@approved_by,remark=@remark,precaution=@precaution,ytd_vol=@ytd_vol,atc_vol=@atc_vol,created_by=@created_by,create_date=@create_date,updated_by=@updated_by,update_date=@update_date,other_fee=@other_fee,charging_fee=@charging_fee,treatment_1=@treatment_1,treatment_2=@treatment_2,treatment_3=@treatment_3,treatment_4=@treatment_4,treatment_other=@treatment_other,type_1=@type_1,type_2=@type_2,type_3=@type_3,type_4=@type_4,type_5=@type_5,type_other=@type_other,xt_1=@xt_1,xt_2=@xt_2,xt_3=@xt_3,out_1=@out_1,out_2=@out_2,out_3=@out_3,bzfs=@bzfs,zycf=@zycf,stutas=@stutas,ht_bm=@ht_bm,color=@color,is_cy=@is_cy,fwcs_bh=@fwcs_bh,sc_fzr=@sc_fzr,zx_bh=@zx_bh,xt_4=@xt_4,cf_1=@cf_1,cf_2=@cf_2,cf_3=@cf_3,cf_4=@cf_4,cf_5=@cf_5,cf_6=@cf_6,cf_7=@cf_7,cf_8=@cf_8,jy_1=@jy_1,jy_2=@jy_2,reason=@reason,waste_bzfs=@waste_bzfs,waste_ysfs=@waste_ysfs,unsh=@unsh,unshr=@unshr,unshrq=@unshrq where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Wast_SelectById

@bh varchar(18)=null

AS
BEGIN
	select * from Wast where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Wast_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Wast'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Wast_SelectAll
AS
BEGIN
	select * from Wast
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Work_team_Add

@bm varchar(18),
@mc varchar(30)=null

AS
BEGIN
	insert into Work_team values(@bm,@mc)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Work_team_Delete

@bm varchar(18)

AS
BEGIN
	delete from Work_team where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Work_team_Change

@bm varchar(18),
@mc varchar(30)=null

AS
BEGIN
	update Work_team set mc=@mc where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Work_team_SelectById

@bm varchar(18)

AS
BEGIN
	select * from Work_team where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Work_team_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Work_team'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Work_team_SelectAll
AS
BEGIN
	select * from Work_team
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Client_com_Add

@bh varchar(18)=null,
@mc varchar(60)=null,
@com varchar(20)=null,
@pt varchar(18)=null,
@sjw varchar(12)=null,
@tzw varchar(12)=null,
@syw varchar(18)=null,
@is_stop tinyint

AS
BEGIN
	insert into Client_com values(@bh,@mc,@com,@pt,@sjw,@tzw,@syw,@is_stop)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Client_com_Delete

@bm int

AS
BEGIN
	delete from Client_com where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Client_com_Change

@bm int,
@bh varchar(18)=null,
@mc varchar(60)=null,
@com varchar(20)=null,
@pt varchar(18)=null,
@sjw varchar(12)=null,
@tzw varchar(12)=null,
@syw varchar(18)=null,
@is_stop tinyint

AS
BEGIN
	update Client_com set bh=@bh,mc=@mc,com=@com,pt=@pt,sjw=@sjw,tzw=@tzw,syw=@syw,is_stop=@is_stop where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Client_com_SelectById

@bm int

AS
BEGIN
	select * from Client_com where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Client_com_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Client_com'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Client_com_SelectAll
AS
BEGIN
	select * from Client_com
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Waste_unsh_record_Add

@waste_id varchar(18)=null,
@unsh_by varchar(18)=null,
@unsh_date datetime=null,
@bz varchar(100)=null,
@remark char(70)=null

AS
BEGIN
	insert into Waste_unsh_record values(@waste_id,@unsh_by,@unsh_date,@bz,@remark)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Waste_unsh_record_Delete

@bm int

AS
BEGIN
	delete from Waste_unsh_record where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Waste_unsh_record_Change

@bm int,
@waste_id varchar(18)=null,
@unsh_by varchar(18)=null,
@unsh_date datetime=null,
@bz varchar(100)=null,
@remark char(70)=null

AS
BEGIN
	update Waste_unsh_record set waste_id=@waste_id,unsh_by=@unsh_by,unsh_date=@unsh_date,bz=@bz,remark=@remark where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Waste_unsh_record_SelectById

@bm int

AS
BEGIN
	select * from Waste_unsh_record where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Waste_unsh_record_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Waste_unsh_record'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Waste_unsh_record_SelectAll
AS
BEGIN
	select * from Waste_unsh_record
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Samples_qqc_Add

@bh varchar(18),
@sample_id varchar(18)=null,
@waste_id varchar(18)=null,
@result tinyint,
@created_by varchar(12)=null,
@create_date datetime=null,
@qqc_yyy varchar(12)=null,
@status varchar(2)=null,
@qqc_date datetime=null,
@customer_num varchar(18)=null,
@waste_code varchar(18)=null

AS
BEGIN
	insert into Samples_qqc values(@bh,@sample_id,@waste_id,@result,@created_by,@create_date,@qqc_yyy,@status,@qqc_date,@customer_num,@waste_code)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Samples_qqc_Delete

@bh varchar(18)

AS
BEGIN
	delete from Samples_qqc where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Samples_qqc_Change

@bh varchar(18),
@sample_id varchar(18)=null,
@waste_id varchar(18)=null,
@result tinyint,
@created_by varchar(12)=null,
@create_date datetime=null,
@qqc_yyy varchar(12)=null,
@status varchar(2)=null,
@qqc_date datetime=null,
@customer_num varchar(18)=null,
@waste_code varchar(18)=null

AS
BEGIN
	update Samples_qqc set sample_id=@sample_id,waste_id=@waste_id,result=@result,created_by=@created_by,create_date=@create_date,qqc_yyy=@qqc_yyy,status=@status,qqc_date=@qqc_date,customer_num=@customer_num,waste_code=@waste_code where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_qqc_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Samples_qqc where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_qqc_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Samples_qqc'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_qqc_SelectAll
AS
BEGIN
	select * from Samples_qqc
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Component_Add

@bh varchar(18),
@component_id varchar(18),
@component_name varchar(100)=null,
@limit decimal=null,
@dw varchar(18)=null,
@jb_hight decimal=null,
@jb_low decimal=null,
@limit_jc decimal=null,
@group_ss varchar(18)=null,
@edit_times int=null,
@edit_date datetime=null,
@edit_reason varchar(60)=null,
@bz varchar(120)=null,
@wltx varchar(50)=null,
@team_id varchar(18)=null

AS
BEGIN
if(@edit_times=0)
	begin
		set @edit_times=null
	end
	insert into Component values(@bh,@component_id,@component_name,@limit,@dw,@jb_hight,@jb_low,@limit_jc,@group_ss,@edit_times,@edit_date,@edit_reason,@bz,@wltx,@team_id)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Component_Delete

@bh varchar(18)

AS
BEGIN
	delete from Component where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Component_Change

@bh varchar(18),
@component_id varchar(18),
@component_name varchar(100)=null,
@limit decimal=null,
@dw varchar(18)=null,
@jb_hight decimal=null,
@jb_low decimal=null,
@limit_jc decimal=null,
@group_ss varchar(18)=null,
@edit_times int=null,
@edit_date datetime=null,
@edit_reason varchar(60)=null,
@bz varchar(120)=null,
@wltx varchar(50)=null,
@team_id varchar(18)=null

AS
BEGIN
if(@edit_times=0)
	begin
		set @edit_times=null
	end
	update Component set component_id=@component_id,component_name=@component_name,limit=@limit,dw=@dw,jb_hight=@jb_hight,jb_low=@jb_low,limit_jc=@limit_jc,group_ss=@group_ss,edit_times=@edit_times,edit_date=@edit_date,edit_reason=@edit_reason,bz=@bz,wltx=@wltx,team_id=@team_id where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Component_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Component where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Component_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Component'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Component_SelectAll
AS
BEGIN
	select * from Component
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Samples_detail_Add

@bh varchar(18),
@sample_id varchar(18),
@component_id varchar(18),
@component_name varchar(60)=null,
@limit decimal=null,
@limit_jc decimal=null,
@kzzb_hight decimal=null,
@kzzb_row decimal=null,
@kzjg decimal=null,
@sss varchar(20)=null,
@edit_reason varchar(80)=null,
@edit_times tinyint=null,
@dw varchar(12)=null,
@edit_by varchar(18)=null,
@edit_date datetime=null,
@bz varchar(150)=null,
@status tinyint=null,
@jc_result varchar(50)=null,
@bzr varchar(12)=null,
@bz_date datetime=null,
@lock tinyint=null,
@user_name varchar(30)=null,
@is_bz tinyint=null,
@is_decimal tinyint=null,
@del_by varchar(18)=null,
@del_rq datetime=null,
@del_bz varchar(100)=null

AS
BEGIN
	insert into Samples_detail values(@bh,@sample_id,@component_id,@component_name,@limit,@limit_jc,@kzzb_hight,@kzzb_row,@kzjg,@sss,@edit_reason,@edit_times,@dw,@edit_by,@edit_date,@bz,@status,@jc_result,@bzr,@bz_date,@lock,@user_name,@is_bz,@is_decimal,@del_by,@del_rq,@del_bz)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Samples_detail_Delete

@bh varchar(18)

AS
BEGIN
	delete from Samples_detail where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Samples_detail_Change

@bh varchar(18),
@sample_id varchar(18),
@component_id varchar(18),
@component_name varchar(60)=null,
@limit decimal=null,
@limit_jc decimal=null,
@kzzb_hight decimal=null,
@kzzb_row decimal=null,
@kzjg decimal=null,
@sss varchar(20)=null,
@edit_reason varchar(80)=null,
@edit_times tinyint=null,
@dw varchar(12)=null,
@edit_by varchar(18)=null,
@edit_date datetime=null,
@bz varchar(150)=null,
@status tinyint=null,
@jc_result varchar(50)=null,
@bzr varchar(12)=null,
@bz_date datetime=null,
@lock tinyint=null,
@user_name varchar(30)=null,
@is_bz tinyint=null,
@is_decimal tinyint=null,
@del_by varchar(18)=null,
@del_rq datetime=null,
@del_bz varchar(100)=null

AS
BEGIN
	update Samples_detail set sample_id=@sample_id,component_id=@component_id,component_name=@component_name,limit=@limit,limit_jc=@limit_jc,kzzb_hight=@kzzb_hight,kzzb_row=@kzzb_row,kzjg=@kzjg,sss=@sss,edit_reason=@edit_reason,edit_times=@edit_times,dw=@dw,edit_by=@edit_by,edit_date=@edit_date,bz=@bz,status=@status,jc_result=@jc_result,bzr=@bzr,bz_date=@bz_date,lock=@lock,user_name=@user_name,is_bz=@is_bz,is_decimal=@is_decimal,del_by=@del_by,del_rq=@del_rq,del_bz=@del_bz where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_detail_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Samples_detail where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_detail_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Samples_detail'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_detail_SelectAll
AS
BEGIN
	select * from Samples_detail
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Company_Add

@company_name varchar(60)=null,
@company_bh varchar(30)=null,
@address varchar(100)=null,
@tel varchar(16)=null,
@fax varchar(16)=null,
@qq int=null,
@e_mail varchar(20)=null,
@mail varchar(16)=null,
@corporation varchar(16)=null,
@licence varchar(40)=null,
@fzr varchar(16)=null,
@rq datetime=null,
@jsjl varchar(12)=null,
@cjzg varchar(12)=null,
@n1 varchar(12)=null,
@n2 varchar(12)=null,
@n3 varchar(12)=null,
@qx varchar(20)=null

AS
BEGIN
if(@qq=0)
	begin
		set @qq=null
	end
	insert into Company values(@company_name,@company_bh,@address,@tel,@fax,@qq,@e_mail,@mail,@corporation,@licence,@fzr,@rq,@jsjl,@cjzg,@n1,@n2,@n3,@qx)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Company_Delete

@company_name varchar(60)

AS
BEGIN
	delete from Company where company_name=@company_name
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Company_Change

@company_name varchar(60)=null,
@company_bh varchar(30)=null,
@address varchar(100)=null,
@tel varchar(16)=null,
@fax varchar(16)=null,
@qq int=null,
@e_mail varchar(20)=null,
@mail varchar(16)=null,
@corporation varchar(16)=null,
@licence varchar(40)=null,
@fzr varchar(16)=null,
@rq datetime=null,
@jsjl varchar(12)=null,
@cjzg varchar(12)=null,
@n1 varchar(12)=null,
@n2 varchar(12)=null,
@n3 varchar(12)=null,
@qx varchar(20)=null

AS
BEGIN
if(@qq=0)
	begin
		set @qq=null
	end
	update Company set company_bh=@company_bh,address=@address,tel=@tel,fax=@fax,qq=@qq,e_mail=@e_mail,mail=@mail,corporation=@corporation,licence=@licence,fzr=@fzr,rq=@rq,jsjl=@jsjl,cjzg=@cjzg,n1=@n1,n2=@n2,n3=@n3,qx=@qx where company_name=@company_name
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Company_SelectById

@company_name varchar(60)=null

AS
BEGIN
	select * from Company where company_name=@company_name
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Company_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Company'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Company_SelectAll
AS
BEGIN
	select * from Company
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Xjyh_customer_Add

@bh varchar(18),
@bm varchar(18)=null,
@mc varchar(30)=null,
@customer_num varchar(18),
@charging decimal,
@bz varchar(100)=null,
@is_sh tinyint,
@shr varchar(18)=null,
@sh_date datetime=null,
@created_by varchar(18)=null,
@create_date datetime=null,
@updated_by varchar(18)=null,
@update_date datetime=null

AS
BEGIN
	insert into Xjyh_customer values(@bh,@bm,@mc,@customer_num,@charging,@bz,@is_sh,@shr,@sh_date,@created_by,@create_date,@updated_by,@update_date)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Xjyh_customer_Delete

@bh varchar(18)

AS
BEGIN
	delete from Xjyh_customer where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Xjyh_customer_Change

@bh varchar(18),
@bm varchar(18)=null,
@mc varchar(30)=null,
@customer_num varchar(18),
@charging decimal,
@bz varchar(100)=null,
@is_sh tinyint,
@shr varchar(18)=null,
@sh_date datetime=null,
@created_by varchar(18)=null,
@create_date datetime=null,
@updated_by varchar(18)=null,
@update_date datetime=null

AS
BEGIN
	update Xjyh_customer set bm=@bm,mc=@mc,customer_num=@customer_num,charging=@charging,bz=@bz,is_sh=@is_sh,shr=@shr,sh_date=@sh_date,created_by=@created_by,create_date=@create_date,updated_by=@updated_by,update_date=@update_date where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Xjyh_customer_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Xjyh_customer where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Xjyh_customer_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Xjyh_customer'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Xjyh_customer_SelectAll
AS
BEGIN
	select * from Xjyh_customer
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Samples_Add

@bh varchar(18)=null,
@sample_id varchar(16),
@status varchar(12)=null,
@userstamp varchar(40)=null,
@sample_date datetime=null,
@request_id varchar(60)=null,
@js_date datetime=null,
@sent_to varchar(18)=null,
@sample_type varchar(18)=null,
@process_waste varchar(60)=null,
@customer_num varchar(18)=null,
@customer_name varchar(40)=null,
@customer_adress varchar(100)=null,
@facitily_colcation varchar(60)=null,
@waste_id varchar(18)=null,
@test_date1 datetime=null,
@test_date2 datetime=null,
@result char(4)=null,
@profile_id char(18)=null,
@update_date datetime=null,
@updated_by varchar(18)=null,
@created_by varchar(12)=null,
@create_date datetime=null,
@is_ok tinyint=null,
@is_print tinyint=null,
@qqc tinyint=null,
@yp_name varchar(60)=null,
@yp_fl varchar(30)=null,
@yp_ly varchar(30)=null,
@yp_wz varchar(60)=null,
@yp_person varchar(12)=null,
@sq_date datetime=null,
@sq_person varchar(12)=null,
@completes_date datetime=null,
@yp_ms varchar(100)=null,
@js_person varchar(12)=null,
@shr varchar(12)=null,
@sh_date datetime=null,
@del_by varchar(18)=null,
@del_rq datetime=null,
@del_bz varchar(100)=null

AS
BEGIN
	insert into Samples values(@bh,@sample_id,@status,@userstamp,@sample_date,@request_id,@js_date,@sent_to,@sample_type,@process_waste,@customer_num,@customer_name,@customer_adress,@facitily_colcation,@waste_id,@test_date1,@test_date2,@result,@profile_id,@update_date,@updated_by,@created_by,@create_date,@is_ok,@is_print,@qqc,@yp_name,@yp_fl,@yp_ly,@yp_wz,@yp_person,@sq_date,@sq_person,@completes_date,@yp_ms,@js_person,@shr,@sh_date,@del_by,@del_rq,@del_bz)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Samples_Delete

@bh varchar(18)

AS
BEGIN
	delete from Samples where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Samples_Change

@bh varchar(18)=null,
@sample_id varchar(16),
@status varchar(12)=null,
@userstamp varchar(40)=null,
@sample_date datetime=null,
@request_id varchar(60)=null,
@js_date datetime=null,
@sent_to varchar(18)=null,
@sample_type varchar(18)=null,
@process_waste varchar(60)=null,
@customer_num varchar(18)=null,
@customer_name varchar(40)=null,
@customer_adress varchar(100)=null,
@facitily_colcation varchar(60)=null,
@waste_id varchar(18)=null,
@test_date1 datetime=null,
@test_date2 datetime=null,
@result char(4)=null,
@profile_id char(18)=null,
@update_date datetime=null,
@updated_by varchar(18)=null,
@created_by varchar(12)=null,
@create_date datetime=null,
@is_ok tinyint=null,
@is_print tinyint=null,
@qqc tinyint=null,
@yp_name varchar(60)=null,
@yp_fl varchar(30)=null,
@yp_ly varchar(30)=null,
@yp_wz varchar(60)=null,
@yp_person varchar(12)=null,
@sq_date datetime=null,
@sq_person varchar(12)=null,
@completes_date datetime=null,
@yp_ms varchar(100)=null,
@js_person varchar(12)=null,
@shr varchar(12)=null,
@sh_date datetime=null,
@del_by varchar(18)=null,
@del_rq datetime=null,
@del_bz varchar(100)=null

AS
BEGIN
	update Samples set sample_id=@sample_id,status=@status,userstamp=@userstamp,sample_date=@sample_date,request_id=@request_id,js_date=@js_date,sent_to=@sent_to,sample_type=@sample_type,process_waste=@process_waste,customer_num=@customer_num,customer_name=@customer_name,customer_adress=@customer_adress,facitily_colcation=@facitily_colcation,waste_id=@waste_id,test_date1=@test_date1,test_date2=@test_date2,result=@result,profile_id=@profile_id,update_date=@update_date,updated_by=@updated_by,created_by=@created_by,create_date=@create_date,is_ok=@is_ok,is_print=@is_print,qqc=@qqc,yp_name=@yp_name,yp_fl=@yp_fl,yp_ly=@yp_ly,yp_wz=@yp_wz,yp_person=@yp_person,sq_date=@sq_date,sq_person=@sq_person,completes_date=@completes_date,yp_ms=@yp_ms,js_person=@js_person,shr=@shr,sh_date=@sh_date,del_by=@del_by,del_rq=@del_rq,del_bz=@del_bz where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_SelectById

@bh varchar(18)=null

AS
BEGIN
	select * from Samples where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Samples'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_SelectAll
AS
BEGIN
	select * from Samples
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Finance_Add

@processing_date datetime=null,
@ticket_num varchar(18)=null,
@container_id varchar(18),
@waste_id varchar(18)=null,
@weight decimal=null,
@charging decimal=null,
@billing_id varchar(18),
@bh varchar(18)=null,
@yyy char(10)=null,
@zdr char(10)=null,
@bz varchar(100)=null,
@zy varchar(100)=null,
@charging_fee decimal=null,
@other_fee decimal=null,
@treatment_rate decimal=null,
@treatment_je decimal=null,
@charging_zz decimal=null,
@charging_yjs decimal=null,
@charging_wjs decimal=null

AS
BEGIN
	insert into Finance values(@processing_date,@ticket_num,@container_id,@waste_id,@weight,@charging,@billing_id,@bh,@yyy,@zdr,@bz,@zy,@charging_fee,@other_fee,@treatment_rate,@treatment_je,@charging_zz,@charging_yjs,@charging_wjs)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Finance_Delete

@processing_date datetime

AS
BEGIN
	delete from Finance where processing_date=@processing_date
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Finance_Change

@processing_date datetime=null,
@ticket_num varchar(18)=null,
@container_id varchar(18),
@waste_id varchar(18)=null,
@weight decimal=null,
@charging decimal=null,
@billing_id varchar(18),
@bh varchar(18)=null,
@yyy char(10)=null,
@zdr char(10)=null,
@bz varchar(100)=null,
@zy varchar(100)=null,
@charging_fee decimal=null,
@other_fee decimal=null,
@treatment_rate decimal=null,
@treatment_je decimal=null,
@charging_zz decimal=null,
@charging_yjs decimal=null,
@charging_wjs decimal=null

AS
BEGIN
	update Finance set ticket_num=@ticket_num,container_id=@container_id,waste_id=@waste_id,weight=@weight,charging=@charging,billing_id=@billing_id,bh=@bh,yyy=@yyy,zdr=@zdr,bz=@bz,zy=@zy,charging_fee=@charging_fee,other_fee=@other_fee,treatment_rate=@treatment_rate,treatment_je=@treatment_je,charging_zz=@charging_zz,charging_yjs=@charging_yjs,charging_wjs=@charging_wjs where processing_date=@processing_date
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Finance_SelectById

@processing_date datetime=null

AS
BEGIN
	select * from Finance where processing_date=@processing_date
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Finance_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Finance'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Finance_SelectAll
AS
BEGIN
	select * from Finance
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Finance_zz_Add

@bh varchar(18),
@ticket_num varchar(18)=null,
@billing_id varchar(18)=null,
@customer_num varchar(18),
@create_date datetime=null,
@waste_id varchar(18)=null,
@collector_num varchar(18)=null,
@charging_all decimal,
@zr decimal,
@charging_js decimal,
@charging_ye decimal,
@sl int,
@js_sl int,
@zf_sl int,
@weight decimal,
@js_weight decimal,
@yyy varchar(12)=null,
@created_by varchar(12)=null

AS
BEGIN
	insert into Finance_zz values(@bh,@ticket_num,@billing_id,@customer_num,@create_date,@waste_id,@collector_num,@charging_all,@zr,@charging_js,@charging_ye,@sl,@js_sl,@zf_sl,@weight,@js_weight,@yyy,@created_by)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Finance_zz_Delete

@bh varchar(18)

AS
BEGIN
	delete from Finance_zz where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Finance_zz_Change

@bh varchar(18),
@ticket_num varchar(18)=null,
@billing_id varchar(18)=null,
@customer_num varchar(18),
@create_date datetime=null,
@waste_id varchar(18)=null,
@collector_num varchar(18)=null,
@charging_all decimal,
@zr decimal,
@charging_js decimal,
@charging_ye decimal,
@sl int,
@js_sl int,
@zf_sl int,
@weight decimal,
@js_weight decimal,
@yyy varchar(12)=null,
@created_by varchar(12)=null

AS
BEGIN
	update Finance_zz set ticket_num=@ticket_num,billing_id=@billing_id,customer_num=@customer_num,create_date=@create_date,waste_id=@waste_id,collector_num=@collector_num,charging_all=@charging_all,zr=@zr,charging_js=@charging_js,charging_ye=@charging_ye,sl=@sl,js_sl=@js_sl,zf_sl=@zf_sl,weight=@weight,js_weight=@js_weight,yyy=@yyy,created_by=@created_by where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Finance_zz_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Finance_zz where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Finance_zz_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Finance_zz'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Finance_zz_SelectAll
AS
BEGIN
	select * from Finance_zz
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Finance_head_Add

@bh varchar(18),
@billing_id varchar(18),
@ticket_num varchar(18)=null,
@waste_id varchar(18)=null,
@collector_num varchar(18)=null,
@charging decimal,
@weight decimal,
@customer_num varchar(18)=null,
@processing_date datetime=null,
@yyy varchar(12)=null,
@zdr varchar(12)=null,
@bz varchar(100)=null,
@zy varchar(100)=null,
@old_billing varchar(18)=null,
@zh varchar(18)=null,
@charging_js decimal=null,
@charging_yj decimal=null,
@charging_ye decimal=null,
@ml decimal=null,
@js_date1 datetime=null,
@js_date2 datetime=null

AS
BEGIN
	insert into Finance_head values(@bh,@billing_id,@ticket_num,@waste_id,@collector_num,@charging,@weight,@customer_num,@processing_date,@yyy,@zdr,@bz,@zy,@old_billing,@zh,@charging_js,@charging_yj,@charging_ye,@ml,@js_date1,@js_date2)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Finance_head_Delete

@bh varchar(18)

AS
BEGIN
	delete from Finance_head where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Finance_head_Change

@bh varchar(18),
@billing_id varchar(18),
@ticket_num varchar(18)=null,
@waste_id varchar(18)=null,
@collector_num varchar(18)=null,
@charging decimal,
@weight decimal,
@customer_num varchar(18)=null,
@processing_date datetime=null,
@yyy varchar(12)=null,
@zdr varchar(12)=null,
@bz varchar(100)=null,
@zy varchar(100)=null,
@old_billing varchar(18)=null,
@zh varchar(18)=null,
@charging_js decimal=null,
@charging_yj decimal=null,
@charging_ye decimal=null,
@ml decimal=null,
@js_date1 datetime=null,
@js_date2 datetime=null

AS
BEGIN
	update Finance_head set billing_id=@billing_id,ticket_num=@ticket_num,waste_id=@waste_id,collector_num=@collector_num,charging=@charging,weight=@weight,customer_num=@customer_num,processing_date=@processing_date,yyy=@yyy,zdr=@zdr,bz=@bz,zy=@zy,old_billing=@old_billing,zh=@zh,charging_js=@charging_js,charging_yj=@charging_yj,charging_ye=@charging_ye,ml=@ml,js_date1=@js_date1,js_date2=@js_date2 where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Finance_head_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Finance_head where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Finance_head_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Finance_head'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Finance_head_SelectAll
AS
BEGIN
	select * from Finance_head
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Sys_number_Add

@type varchar(10),
@num int=null,
@rq datetime=null,
@remarks nvarchar(100)=null

AS
BEGIN
if(@num=0)
	begin
		set @num=null
	end
	insert into Sys_number values(@type,@num,@rq,@remarks)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Sys_number_Delete

@type varchar(10)

AS
BEGIN
	delete from Sys_number where type=@type
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Sys_number_Change

@type varchar(10),
@num int=null,
@rq datetime=null,
@remarks nvarchar(100)=null

AS
BEGIN
if(@num=0)
	begin
		set @num=null
	end
	update Sys_number set num=@num,rq=@rq,remarks=@remarks where type=@type
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Sys_number_SelectById

@type varchar(10)

AS
BEGIN
	select * from Sys_number where type=@type
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Sys_number_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Sys_number'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Sys_number_SelectAll
AS
BEGIN
	select * from Sys_number
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Keep_table_Add

@num int=null,

AS
BEGIN
if(@num=0)
	begin
		set @num=null
	end
	insert into Keep_table values(@num,)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Keep_table_Delete

@num int

AS
BEGIN
	delete from Keep_table where num=@num
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Keep_table_Change

@num int=null,

AS
BEGIN
if(@num=0)
	begin
		set @num=null
	end
	update Keep_table set  where num=@num
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Keep_table_SelectById

@num int=null

AS
BEGIN
	select * from Keep_table where num=@num
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Keep_table_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Keep_table'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Keep_table_SelectAll
AS
BEGIN
	select * from Keep_table
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Mgr_user_group_Add

@group_id varchar(16),
@group_name varchar(30)=null,
@is_pos int=null,
@bz varchar(200)=null,
@grant_menu text=null,
@grant_control text=null,
@grant_other text=null,
@grant_pos text=null,
@sss_id varchar(18)=null,
@sss varchar(30)=null

AS
BEGIN
if(@is_pos=0)
	begin
		set @is_pos=null
	end
	insert into Mgr_user_group values(@group_id,@group_name,@is_pos,@bz,@grant_menu,@grant_control,@grant_other,@grant_pos,@sss_id,@sss)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Mgr_user_group_Delete

@group_id varchar(16)

AS
BEGIN
	delete from Mgr_user_group where group_id=@group_id
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Mgr_user_group_Change

@group_id varchar(16),
@group_name varchar(30)=null,
@is_pos int=null,
@bz varchar(200)=null,
@grant_menu text=null,
@grant_control text=null,
@grant_other text=null,
@grant_pos text=null,
@sss_id varchar(18)=null,
@sss varchar(30)=null

AS
BEGIN
if(@is_pos=0)
	begin
		set @is_pos=null
	end
	update Mgr_user_group set group_name=@group_name,is_pos=@is_pos,bz=@bz,grant_menu=@grant_menu,grant_control=@grant_control,grant_other=@grant_other,grant_pos=@grant_pos,sss_id=@sss_id,sss=@sss where group_id=@group_id
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Mgr_user_group_SelectById

@group_id varchar(16)

AS
BEGIN
	select * from Mgr_user_group where group_id=@group_id
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Mgr_user_group_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Mgr_user_group'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Mgr_user_group_SelectAll
AS
BEGIN
	select * from Mgr_user_group
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Billing_Add

@bh varchar(18)=null,
@billing_id varchar(18),
@billing_date datetime=null,
@status varchar(1)=null

AS
BEGIN
	insert into Billing values(@bh,@billing_id,@billing_date,@status)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Billing_Delete

@bh varchar(18)

AS
BEGIN
	delete from Billing where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Billing_Change

@bh varchar(18)=null,
@billing_id varchar(18),
@billing_date datetime=null,
@status varchar(1)=null

AS
BEGIN
	update Billing set billing_id=@billing_id,billing_date=@billing_date,status=@status where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Billing_SelectById

@bh varchar(18)=null

AS
BEGIN
	select * from Billing where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Billing_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Billing'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Billing_SelectAll
AS
BEGIN
	select * from Billing
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_component_Add

@bh varchar(18),
@component_id varchar(18),
@component_name varchar(50)=null,
@limit decimal=null,
@dw varchar(18)=null,
@jb_hight decimal=null,
@jb_low decimal=null,
@limit_jc decimal=null,
@group_ss varchar(18)=null,
@edit_times int=null,
@edit_date datetime=null,
@edit_reason varchar(60)=null,
@bz varchar(120)=null

AS
BEGIN
if(@edit_times=0)
	begin
		set @edit_times=null
	end
	insert into Qqc_component values(@bh,@component_id,@component_name,@limit,@dw,@jb_hight,@jb_low,@limit_jc,@group_ss,@edit_times,@edit_date,@edit_reason,@bz)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_component_Delete

@bh varchar(18)

AS
BEGIN
	delete from Qqc_component where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_component_Change

@bh varchar(18),
@component_id varchar(18),
@component_name varchar(50)=null,
@limit decimal=null,
@dw varchar(18)=null,
@jb_hight decimal=null,
@jb_low decimal=null,
@limit_jc decimal=null,
@group_ss varchar(18)=null,
@edit_times int=null,
@edit_date datetime=null,
@edit_reason varchar(60)=null,
@bz varchar(120)=null

AS
BEGIN
if(@edit_times=0)
	begin
		set @edit_times=null
	end
	update Qqc_component set component_id=@component_id,component_name=@component_name,limit=@limit,dw=@dw,jb_hight=@jb_hight,jb_low=@jb_low,limit_jc=@limit_jc,group_ss=@group_ss,edit_times=@edit_times,edit_date=@edit_date,edit_reason=@edit_reason,bz=@bz where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_component_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Qqc_component where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_component_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Qqc_component'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_component_SelectAll
AS
BEGIN
	select * from Qqc_component
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Foot_status_Add

@win varchar(50),
@clear_win int=null,
@exit_win int=null

AS
BEGIN
if(@clear_win=0)
	begin
		set @clear_win=null
	end
if(@exit_win=0)
	begin
		set @exit_win=null
	end
	insert into Foot_status values(@win,@clear_win,@exit_win)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Foot_status_Delete

@win varchar(50)

AS
BEGIN
	delete from Foot_status where win=@win
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Foot_status_Change

@win varchar(50),
@clear_win int=null,
@exit_win int=null

AS
BEGIN
if(@clear_win=0)
	begin
		set @clear_win=null
	end
if(@exit_win=0)
	begin
		set @exit_win=null
	end
	update Foot_status set clear_win=@clear_win,exit_win=@exit_win where win=@win
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Foot_status_SelectById

@win varchar(50)

AS
BEGIN
	select * from Foot_status where win=@win
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Foot_status_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Foot_status'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Foot_status_SelectAll
AS
BEGIN
	select * from Foot_status
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Bmfl_dq_Add

@bh varchar(18),
@bm varchar(16),
@mc varchar(50)=null,
@js int=null,
@bm_1 varchar(50)=null,
@bm_2 varchar(50)=null,
@bm_3 varchar(50)=null,
@bm_4 varchar(50)=null

AS
BEGIN
if(@js=0)
	begin
		set @js=null
	end
	insert into Bmfl_dq values(@bh,@bm,@mc,@js,@bm_1,@bm_2,@bm_3,@bm_4)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Bmfl_dq_Delete

@bh varchar(18)

AS
BEGIN
	delete from Bmfl_dq where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Bmfl_dq_Change

@bh varchar(18),
@bm varchar(16),
@mc varchar(50)=null,
@js int=null,
@bm_1 varchar(50)=null,
@bm_2 varchar(50)=null,
@bm_3 varchar(50)=null,
@bm_4 varchar(50)=null

AS
BEGIN
if(@js=0)
	begin
		set @js=null
	end
	update Bmfl_dq set bm=@bm,mc=@mc,js=@js,bm_1=@bm_1,bm_2=@bm_2,bm_3=@bm_3,bm_4=@bm_4 where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Bmfl_dq_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Bmfl_dq where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Bmfl_dq_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Bmfl_dq'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Bmfl_dq_SelectAll
AS
BEGIN
	select * from Bmfl_dq
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Customer_finance_Add

@bh varchar(18),
@bm varchar(18),
@charging decimal,
@skr varchar(12)=null,
@sk_date datetime=null,
@customer_num varchar(18)=null,
@bz varchar(100)=null,
@is_sh tinyint,
@shr varchar(18)=null,
@sh_date datetime=null,
@created_by varchar(18)=null,
@create_date datetime=null,
@updated_by varchar(18)=null,
@update_date datetime=null

AS
BEGIN
	insert into Customer_finance values(@bh,@bm,@charging,@skr,@sk_date,@customer_num,@bz,@is_sh,@shr,@sh_date,@created_by,@create_date,@updated_by,@update_date)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Customer_finance_Delete

@bh varchar(18)

AS
BEGIN
	delete from Customer_finance where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Customer_finance_Change

@bh varchar(18),
@bm varchar(18),
@charging decimal,
@skr varchar(12)=null,
@sk_date datetime=null,
@customer_num varchar(18)=null,
@bz varchar(100)=null,
@is_sh tinyint,
@shr varchar(18)=null,
@sh_date datetime=null,
@created_by varchar(18)=null,
@create_date datetime=null,
@updated_by varchar(18)=null,
@update_date datetime=null

AS
BEGIN
	update Customer_finance set bm=@bm,charging=@charging,skr=@skr,sk_date=@sk_date,customer_num=@customer_num,bz=@bz,is_sh=@is_sh,shr=@shr,sh_date=@sh_date,created_by=@created_by,create_date=@create_date,updated_by=@updated_by,update_date=@update_date where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Customer_finance_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Customer_finance where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Customer_finance_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Customer_finance'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Customer_finance_SelectAll
AS
BEGIN
	select * from Customer_finance
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Container_detail_Add

@bh varchar(18),
@container_id varchar(18),
@ticket_num varchar(18),
@net_weight decimal=null,
@date_time datetime=null,
@location_id varchar(18)=null,
@status varchar(3)=null

AS
BEGIN
	insert into Container_detail values(@bh,@container_id,@ticket_num,@net_weight,@date_time,@location_id,@status)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Container_detail_Delete

@bh varchar(18)

AS
BEGIN
	delete from Container_detail where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Container_detail_Change

@bh varchar(18),
@container_id varchar(18),
@ticket_num varchar(18),
@net_weight decimal=null,
@date_time datetime=null,
@location_id varchar(18)=null,
@status varchar(3)=null

AS
BEGIN
	update Container_detail set container_id=@container_id,ticket_num=@ticket_num,net_weight=@net_weight,date_time=@date_time,location_id=@location_id,status=@status where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Container_detail_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Container_detail where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Container_detail_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Container_detail'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Container_detail_SelectAll
AS
BEGIN
	select * from Container_detail
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_fast_Add

@bh varchar(18),
@waste_code varchar(18)=null,
@container_id varchar(18)=null,
@created_by varchar(18)=null,
@create_date datetime=null,
@edit_by varchar(18)=null,
@edit_date datetime=null,
@bz varchar(100)=null,
@is_sh tinyint,
@shr varchar(18)=null,
@sh_date datetime=null,
@result tinyint,
@edit_times tinyint

AS
BEGIN
	insert into Qqc_fast values(@bh,@waste_code,@container_id,@created_by,@create_date,@edit_by,@edit_date,@bz,@is_sh,@shr,@sh_date,@result,@edit_times)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_fast_Delete

@bh varchar(18)

AS
BEGIN
	delete from Qqc_fast where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_fast_Change

@bh varchar(18),
@waste_code varchar(18)=null,
@container_id varchar(18)=null,
@created_by varchar(18)=null,
@create_date datetime=null,
@edit_by varchar(18)=null,
@edit_date datetime=null,
@bz varchar(100)=null,
@is_sh tinyint,
@shr varchar(18)=null,
@sh_date datetime=null,
@result tinyint,
@edit_times tinyint

AS
BEGIN
	update Qqc_fast set waste_code=@waste_code,container_id=@container_id,created_by=@created_by,create_date=@create_date,edit_by=@edit_by,edit_date=@edit_date,bz=@bz,is_sh=@is_sh,shr=@shr,sh_date=@sh_date,result=@result,edit_times=@edit_times where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_fast_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Qqc_fast where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_fast_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Qqc_fast'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_fast_SelectAll
AS
BEGIN
	select * from Qqc_fast
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Profile_Add

@bh varchar(18)=null,
@profile_id varchar(18),
@profile_name varchar(50)=null,
@component_id varchar(18),
@stutas tinyint=null,
@xh int=null

AS
BEGIN
if(@xh=0)
	begin
		set @xh=null
	end
	insert into Profile values(@bh,@profile_id,@profile_name,@component_id,@stutas,@xh)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Profile_Delete

@bh varchar(18)

AS
BEGIN
	delete from Profile where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Profile_Change

@bh varchar(18)=null,
@profile_id varchar(18),
@profile_name varchar(50)=null,
@component_id varchar(18),
@stutas tinyint=null,
@xh int=null

AS
BEGIN
if(@xh=0)
	begin
		set @xh=null
	end
	update Profile set profile_id=@profile_id,profile_name=@profile_name,component_id=@component_id,stutas=@stutas,xh=@xh where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Profile_SelectById

@bh varchar(18)=null

AS
BEGIN
	select * from Profile where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Profile_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Profile'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Profile_SelectAll
AS
BEGIN
	select * from Profile
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_fast_detail_Add

@bh varchar(18),
@container_id varchar(18)=null,
@component_id varchar(18),
@component_name varchar(80)=null,
@result tinyint,
@hgz decimal=null,
@bhgz decimal=null,
@bz varchar(100)=null,
@hg varchar(30)=null,
@bhg varchar(30)=null,
@qz_result tinyint=null,
@qzbz varchar(50)=null,
@qz_edit varchar(18)=null,
@qz_editdate datetime=null

AS
BEGIN
	insert into Qqc_fast_detail values(@bh,@container_id,@component_id,@component_name,@result,@hgz,@bhgz,@bz,@hg,@bhg,@qz_result,@qzbz,@qz_edit,@qz_editdate)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_fast_detail_Delete

@bh varchar(18)

AS
BEGIN
	delete from Qqc_fast_detail where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_fast_detail_Change

@bh varchar(18),
@container_id varchar(18)=null,
@component_id varchar(18),
@component_name varchar(80)=null,
@result tinyint,
@hgz decimal=null,
@bhgz decimal=null,
@bz varchar(100)=null,
@hg varchar(30)=null,
@bhg varchar(30)=null,
@qz_result tinyint=null,
@qzbz varchar(50)=null,
@qz_edit varchar(18)=null,
@qz_editdate datetime=null

AS
BEGIN
	update Qqc_fast_detail set container_id=@container_id,component_id=@component_id,component_name=@component_name,result=@result,hgz=@hgz,bhgz=@bhgz,bz=@bz,hg=@hg,bhg=@bhg,qz_result=@qz_result,qzbz=@qzbz,qz_edit=@qz_edit,qz_editdate=@qz_editdate where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_fast_detail_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Qqc_fast_detail where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_fast_detail_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Qqc_fast_detail'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_fast_detail_SelectAll
AS
BEGIN
	select * from Qqc_fast_detail
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_Add

@bh varchar(18)=null,
@waste_id varchar(18),
@temp_id varchar(18),
@sequence_no varchar(2)=null,
@result varchar(10)=null,
@component_id varchar(18)=null,
@component_name varchar(80)=null,
@container_id varchar(18)=null,
@status tinyint=null,
@hgz decimal=null,
@bhgz decimal=null,
@hg varchar(20)=null,
@bhg varchar(20)=null

AS
BEGIN
	insert into Qqc values(@bh,@waste_id,@temp_id,@sequence_no,@result,@component_id,@component_name,@container_id,@status,@hgz,@bhgz,@hg,@bhg)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_Delete

@bh varchar(18)

AS
BEGIN
	delete from Qqc where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_Change

@bh varchar(18)=null,
@waste_id varchar(18),
@temp_id varchar(18),
@sequence_no varchar(2)=null,
@result varchar(10)=null,
@component_id varchar(18)=null,
@component_name varchar(80)=null,
@container_id varchar(18)=null,
@status tinyint=null,
@hgz decimal=null,
@bhgz decimal=null,
@hg varchar(20)=null,
@bhg varchar(20)=null

AS
BEGIN
	update Qqc set waste_id=@waste_id,temp_id=@temp_id,sequence_no=@sequence_no,result=@result,component_id=@component_id,component_name=@component_name,container_id=@container_id,status=@status,hgz=@hgz,bhgz=@bhgz,hg=@hg,bhg=@bhg where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_SelectById

@bh varchar(18)=null

AS
BEGIN
	select * from Qqc where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Qqc'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_SelectAll
AS
BEGIN
	select * from Qqc
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_template_Add

@bh varchar(18)=null,
@temp_id varchar(18),
@name varchar(50)=null,
@sequence_no varchar(2)=null

AS
BEGIN
	insert into Qqc_template values(@bh,@temp_id,@name,@sequence_no)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_template_Delete

@bh varchar(18)

AS
BEGIN
	delete from Qqc_template where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_template_Change

@bh varchar(18)=null,
@temp_id varchar(18),
@name varchar(50)=null,
@sequence_no varchar(2)=null

AS
BEGIN
	update Qqc_template set temp_id=@temp_id,name=@name,sequence_no=@sequence_no where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_template_SelectById

@bh varchar(18)=null

AS
BEGIN
	select * from Qqc_template where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_template_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Qqc_template'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Qqc_template_SelectAll
AS
BEGIN
	select * from Qqc_template
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Js_dq_Add

@bh varchar(18),
@bm varchar(18)=null,
@mc varchar(60)=null,
@oper_type varchar(18)=null,
@created_by varchar(12)=null,
@create_date datetime=null,
@bz varchar(80)=null,
@is_sh tinyint=null,
@sh_date datetime=null,
@shr varchar(18)=null,
@is_stop tinyint=null

AS
BEGIN
	insert into Js_dq values(@bh,@bm,@mc,@oper_type,@created_by,@create_date,@bz,@is_sh,@sh_date,@shr,@is_stop)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Js_dq_Delete

@bh varchar(18)

AS
BEGIN
	delete from Js_dq where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Js_dq_Change

@bh varchar(18),
@bm varchar(18)=null,
@mc varchar(60)=null,
@oper_type varchar(18)=null,
@created_by varchar(12)=null,
@create_date datetime=null,
@bz varchar(80)=null,
@is_sh tinyint=null,
@sh_date datetime=null,
@shr varchar(18)=null,
@is_stop tinyint=null

AS
BEGIN
	update Js_dq set bm=@bm,mc=@mc,oper_type=@oper_type,created_by=@created_by,create_date=@create_date,bz=@bz,is_sh=@is_sh,sh_date=@sh_date,shr=@shr,is_stop=@is_stop where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Js_dq_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Js_dq where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Js_dq_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Js_dq'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Js_dq_SelectAll
AS
BEGIN
	select * from Js_dq
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Results_Add

@bh varchar(18)=null,
@sample_id varchar(18),
@profile_id varchar(18),
@component_name varchar(50)=null,
@result varchar(50)=null,
@updated_by varchar(16)=null,
@update_date datetime=null

AS
BEGIN
	insert into Results values(@bh,@sample_id,@profile_id,@component_name,@result,@updated_by,@update_date)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Results_Delete

@bh varchar(18)

AS
BEGIN
	delete from Results where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Results_Change

@bh varchar(18)=null,
@sample_id varchar(18),
@profile_id varchar(18),
@component_name varchar(50)=null,
@result varchar(50)=null,
@updated_by varchar(16)=null,
@update_date datetime=null

AS
BEGIN
	update Results set sample_id=@sample_id,profile_id=@profile_id,component_name=@component_name,result=@result,updated_by=@updated_by,update_date=@update_date where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Results_SelectById

@bh varchar(18)=null

AS
BEGIN
	select * from Results where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Results_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Results'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Results_SelectAll
AS
BEGIN
	select * from Results
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Tracking_Add

@bh varchar(18),
@container_id varchar(18),
@weight decimal=null,
@date_time datetime=null,
@location_id varchar(18)=null,
@status varchar(3)=null,
@ticket_num varchar(18)=null,
@yyy varchar(18)=null,
@waste_code varchar(18)=null,
@dw varchar(18)=null,
@m_datetime datetime=null,
@tre_yyy varchar(12)=null,
@m_yyy varchar(12)=null,
@tre_datetime datetime=null,
@old_location_id varchar(18)=null,
@m_weight decimal=null,
@old_status varchar(3)=null,
@finance_flag varchar(1)=null,
@tz_weight decimal=null,
@bz char(100)=null

AS
BEGIN
	insert into Tracking values(@bh,@container_id,@weight,@date_time,@location_id,@status,@ticket_num,@yyy,@waste_code,@dw,@m_datetime,@tre_yyy,@m_yyy,@tre_datetime,@old_location_id,@m_weight,@old_status,@finance_flag,@tz_weight,@bz)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Tracking_Delete

@bh varchar(18)

AS
BEGIN
	delete from Tracking where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Tracking_Change

@bh varchar(18),
@container_id varchar(18),
@weight decimal=null,
@date_time datetime=null,
@location_id varchar(18)=null,
@status varchar(3)=null,
@ticket_num varchar(18)=null,
@yyy varchar(18)=null,
@waste_code varchar(18)=null,
@dw varchar(18)=null,
@m_datetime datetime=null,
@tre_yyy varchar(12)=null,
@m_yyy varchar(12)=null,
@tre_datetime datetime=null,
@old_location_id varchar(18)=null,
@m_weight decimal=null,
@old_status varchar(3)=null,
@finance_flag varchar(1)=null,
@tz_weight decimal=null,
@bz char(100)=null

AS
BEGIN
	update Tracking set container_id=@container_id,weight=@weight,date_time=@date_time,location_id=@location_id,status=@status,ticket_num=@ticket_num,yyy=@yyy,waste_code=@waste_code,dw=@dw,m_datetime=@m_datetime,tre_yyy=@tre_yyy,m_yyy=@m_yyy,tre_datetime=@tre_datetime,old_location_id=@old_location_id,m_weight=@m_weight,old_status=@old_status,finance_flag=@finance_flag,tz_weight=@tz_weight,bz=@bz where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Tracking_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Tracking where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Tracking_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Tracking'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Tracking_SelectAll
AS
BEGIN
	select * from Tracking
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Hazard_Add

@bm varchar(18),
@mc varchar(30)=null,
@poto varchar(100)=null,
@saft varchar(200)=null,
@wxqk varchar(200)=null,
@ms varchar(200)=null

AS
BEGIN
	insert into Hazard values(@bm,@mc,@poto,@saft,@wxqk,@ms)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Hazard_Delete

@bm varchar(18)

AS
BEGIN
	delete from Hazard where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Hazard_Change

@bm varchar(18),
@mc varchar(30)=null,
@poto varchar(100)=null,
@saft varchar(200)=null,
@wxqk varchar(200)=null,
@ms varchar(200)=null

AS
BEGIN
	update Hazard set mc=@mc,poto=@poto,saft=@saft,wxqk=@wxqk,ms=@ms where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Hazard_SelectById

@bm varchar(18)

AS
BEGIN
	select * from Hazard where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Hazard_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Hazard'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Hazard_SelectAll
AS
BEGIN
	select * from Hazard
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_Add

@bh varchar(18)=null,
@ticket_num varchar(18),
@customer_num varchar(18)=null,
@waste_id varchar(18)=null,
@collector_num varchar(18)=null,
@vehicle_num varchar(18)=null,
@driver_name varchar(16)=null,
@delivery_date datetime=null,
@start_point varchar(40)=null,
@end_point varchar(40)=null,
@created_by varchar(16)=null,
@create_date datetime=null,
@updated_by varchar(16)=null,
@update_date datetime=null,
@total_weight decimal=null,
@sl int=null,
@fyr varchar(12)=null,
@move_to varchar(100)=null,
@rq_yc datetime=null,
@rq_ys datetime=null,
@fzr varchar(12)=null,
@rq_js datetime=null,
@cyr varchar(12)=null,
@year_yc char(4)=null,
@month_yc char(2)=null,
@day_yc char(2)=null,
@year_ys char(4)=null,
@month_ys char(2)=null,
@day_ys char(2)=null,
@year_js char(4)=null,
@month_js char(2)=null,
@day_js char(2)=null,
@status char(5)=null,
@is_cell tinyint=null,
@is_print tinyint=null,
@barcode varchar(400)=null,
@bar_sl int=null,
@sl_zf int=null,
@sl_js int=null,
@dw char(4)=null,
@waste_code varchar(18)=null,
@charging_fee decimal=null,
@treatment_rate decimal=null,
@other_fee decimal=null,
@order_num varchar(22)=null,
@ht_bm varchar(30)=null,
@ys_tel varchar(18)=null,
@ys_address varchar(50)=null,
@ys_mail varchar(20)=null,
@charging_zz decimal=null,
@charging_js decimal=null,
@charging_ye decimal=null,
@finance_flag tinyint=null,
@lock tinyint=null,
@ys_lxr varchar(30)=null,
@htq1 datetime=null,
@htq2 datetime=null

AS
BEGIN
if(@sl=0)
	begin
		set @sl=null
	end
if(@bar_sl=0)
	begin
		set @bar_sl=null
	end
if(@sl_zf=0)
	begin
		set @sl_zf=null
	end
if(@sl_js=0)
	begin
		set @sl_js=null
	end
	insert into Ticket values(@bh,@ticket_num,@customer_num,@waste_id,@collector_num,@vehicle_num,@driver_name,@delivery_date,@start_point,@end_point,@created_by,@create_date,@updated_by,@update_date,@total_weight,@sl,@fyr,@move_to,@rq_yc,@rq_ys,@fzr,@rq_js,@cyr,@year_yc,@month_yc,@day_yc,@year_ys,@month_ys,@day_ys,@year_js,@month_js,@day_js,@status,@is_cell,@is_print,@barcode,@bar_sl,@sl_zf,@sl_js,@dw,@waste_code,@charging_fee,@treatment_rate,@other_fee,@order_num,@ht_bm,@ys_tel,@ys_address,@ys_mail,@charging_zz,@charging_js,@charging_ye,@finance_flag,@lock,@ys_lxr,@htq1,@htq2)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_Delete

@bh varchar(18)

AS
BEGIN
	delete from Ticket where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_Change

@bh varchar(18)=null,
@ticket_num varchar(18),
@customer_num varchar(18)=null,
@waste_id varchar(18)=null,
@collector_num varchar(18)=null,
@vehicle_num varchar(18)=null,
@driver_name varchar(16)=null,
@delivery_date datetime=null,
@start_point varchar(40)=null,
@end_point varchar(40)=null,
@created_by varchar(16)=null,
@create_date datetime=null,
@updated_by varchar(16)=null,
@update_date datetime=null,
@total_weight decimal=null,
@sl int=null,
@fyr varchar(12)=null,
@move_to varchar(100)=null,
@rq_yc datetime=null,
@rq_ys datetime=null,
@fzr varchar(12)=null,
@rq_js datetime=null,
@cyr varchar(12)=null,
@year_yc char(4)=null,
@month_yc char(2)=null,
@day_yc char(2)=null,
@year_ys char(4)=null,
@month_ys char(2)=null,
@day_ys char(2)=null,
@year_js char(4)=null,
@month_js char(2)=null,
@day_js char(2)=null,
@status char(5)=null,
@is_cell tinyint=null,
@is_print tinyint=null,
@barcode varchar(400)=null,
@bar_sl int=null,
@sl_zf int=null,
@sl_js int=null,
@dw char(4)=null,
@waste_code varchar(18)=null,
@charging_fee decimal=null,
@treatment_rate decimal=null,
@other_fee decimal=null,
@order_num varchar(22)=null,
@ht_bm varchar(30)=null,
@ys_tel varchar(18)=null,
@ys_address varchar(50)=null,
@ys_mail varchar(20)=null,
@charging_zz decimal=null,
@charging_js decimal=null,
@charging_ye decimal=null,
@finance_flag tinyint=null,
@lock tinyint=null,
@ys_lxr varchar(30)=null,
@htq1 datetime=null,
@htq2 datetime=null

AS
BEGIN
if(@sl=0)
	begin
		set @sl=null
	end
if(@bar_sl=0)
	begin
		set @bar_sl=null
	end
if(@sl_zf=0)
	begin
		set @sl_zf=null
	end
if(@sl_js=0)
	begin
		set @sl_js=null
	end
	update Ticket set ticket_num=@ticket_num,customer_num=@customer_num,waste_id=@waste_id,collector_num=@collector_num,vehicle_num=@vehicle_num,driver_name=@driver_name,delivery_date=@delivery_date,start_point=@start_point,end_point=@end_point,created_by=@created_by,create_date=@create_date,updated_by=@updated_by,update_date=@update_date,total_weight=@total_weight,sl=@sl,fyr=@fyr,move_to=@move_to,rq_yc=@rq_yc,rq_ys=@rq_ys,fzr=@fzr,rq_js=@rq_js,cyr=@cyr,year_yc=@year_yc,month_yc=@month_yc,day_yc=@day_yc,year_ys=@year_ys,month_ys=@month_ys,day_ys=@day_ys,year_js=@year_js,month_js=@month_js,day_js=@day_js,status=@status,is_cell=@is_cell,is_print=@is_print,barcode=@barcode,bar_sl=@bar_sl,sl_zf=@sl_zf,sl_js=@sl_js,dw=@dw,waste_code=@waste_code,charging_fee=@charging_fee,treatment_rate=@treatment_rate,other_fee=@other_fee,order_num=@order_num,ht_bm=@ht_bm,ys_tel=@ys_tel,ys_address=@ys_address,ys_mail=@ys_mail,charging_zz=@charging_zz,charging_js=@charging_js,charging_ye=@charging_ye,finance_flag=@finance_flag,lock=@lock,ys_lxr=@ys_lxr,htq1=@htq1,htq2=@htq2 where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_SelectById

@bh varchar(18)=null

AS
BEGIN
	select * from Ticket where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Ticket'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_SelectAll
AS
BEGIN
	select * from Ticket
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Xjyh_Add

@bh varchar(18),
@bm varchar(18),
@mc varchar(30),
@init_je decimal,
@je decimal,
@bz varchar(100)=null,
@is_sh tinyint,
@shr varchar(18)=null,
@created_by varchar(18)=null,
@create_date datetime=null,
@updated_by varchar(18)=null,
@update_date datetime=null,
@dress varchar(80)=null

AS
BEGIN
	insert into Xjyh values(@bh,@bm,@mc,@init_je,@je,@bz,@is_sh,@shr,@created_by,@create_date,@updated_by,@update_date,@dress)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Xjyh_Delete

@bh varchar(18)

AS
BEGIN
	delete from Xjyh where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Xjyh_Change

@bh varchar(18),
@bm varchar(18),
@mc varchar(30),
@init_je decimal,
@je decimal,
@bz varchar(100)=null,
@is_sh tinyint,
@shr varchar(18)=null,
@created_by varchar(18)=null,
@create_date datetime=null,
@updated_by varchar(18)=null,
@update_date datetime=null,
@dress varchar(80)=null

AS
BEGIN
	update Xjyh set bm=@bm,mc=@mc,init_je=@init_je,je=@je,bz=@bz,is_sh=@is_sh,shr=@shr,created_by=@created_by,create_date=@create_date,updated_by=@updated_by,update_date=@update_date,dress=@dress where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Xjyh_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Xjyh where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Xjyh_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Xjyh'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Xjyh_SelectAll
AS
BEGIN
	select * from Xjyh
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Sys_format_display_Add

@win_name varchar(30),
@dw_name varchar(40),
@col_no varchar(20),
@col_name varchar(30),
@xh int,
@display_name varchar(40),
@col_width int,
@col_x numeric,
@is_display int,
@is_edit int,
@is_edit_sys int

AS
BEGIN
	insert into Sys_format_display values(@win_name,@dw_name,@col_no,@col_name,@xh,@display_name,@col_width,@col_x,@is_display,@is_edit,@is_edit_sys)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Sys_format_display_Delete

@win_name varchar(30)

AS
BEGIN
	delete from Sys_format_display where win_name=@win_name
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Sys_format_display_Change

@win_name varchar(30),
@dw_name varchar(40),
@col_no varchar(20),
@col_name varchar(30),
@xh int,
@display_name varchar(40),
@col_width int,
@col_x numeric,
@is_display int,
@is_edit int,
@is_edit_sys int

AS
BEGIN
	update Sys_format_display set dw_name=@dw_name,col_no=@col_no,col_name=@col_name,xh=@xh,display_name=@display_name,col_width=@col_width,col_x=@col_x,is_display=@is_display,is_edit=@is_edit,is_edit_sys=@is_edit_sys where win_name=@win_name
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Sys_format_display_SelectById

@win_name varchar(30)

AS
BEGIN
	select * from Sys_format_display where win_name=@win_name
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Sys_format_display_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Sys_format_display'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Sys_format_display_SelectAll
AS
BEGIN
	select * from Sys_format_display
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Collector_Add

@bh varchar(18),
@collector_num varchar(18),
@collector_name varchar(50)=null,
@address varchar(100)=null,
@telephone_no varchar(16)=null,
@mail varchar(16)=null,
@contact_person varchar(40)=null,
@contact_phone_no varchar(16)=null,
@created_by varchar(16)=null,
@create_date datetime=null,
@updated_by varchar(16)=null,
@update_date datetime=null,
@vehicle_num varchar(16)=null,
@driver_name varchar(16)=null,
@lxr varchar(20)=null

AS
BEGIN
	insert into Collector values(@bh,@collector_num,@collector_name,@address,@telephone_no,@mail,@contact_person,@contact_phone_no,@created_by,@create_date,@updated_by,@update_date,@vehicle_num,@driver_name,@lxr)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Collector_Delete

@bh varchar(18)

AS
BEGIN
	delete from Collector where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Collector_Change

@bh varchar(18),
@collector_num varchar(18),
@collector_name varchar(50)=null,
@address varchar(100)=null,
@telephone_no varchar(16)=null,
@mail varchar(16)=null,
@contact_person varchar(40)=null,
@contact_phone_no varchar(16)=null,
@created_by varchar(16)=null,
@create_date datetime=null,
@updated_by varchar(16)=null,
@update_date datetime=null,
@vehicle_num varchar(16)=null,
@driver_name varchar(16)=null,
@lxr varchar(20)=null

AS
BEGIN
	update Collector set collector_num=@collector_num,collector_name=@collector_name,address=@address,telephone_no=@telephone_no,mail=@mail,contact_person=@contact_person,contact_phone_no=@contact_phone_no,created_by=@created_by,create_date=@create_date,updated_by=@updated_by,update_date=@update_date,vehicle_num=@vehicle_num,driver_name=@driver_name,lxr=@lxr where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Collector_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Collector where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Collector_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Collector'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Collector_SelectAll
AS
BEGIN
	select * from Collector
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Customer_Add

@bh varchar(18),
@customer_num varchar(18),
@customer_name varchar(50)=null,
@bm_dqfl varchar(50)=null,
@address varchar(100)=null,
@telephone_no varchar(16)=null,
@mail varchar(16)=null,
@contact_person varchar(16)=null,
@contact_phone_no varchar(16)=null,
@created_by varchar(16)=null,
@created_date datetime=null,
@updated_by varchar(16)=null,
@update_date datetime=null,
@status varchar(1)=null,
@sales_person varchar(16)=null,
@fzr_dz char(60)=null,
@fax varchar(20)=null,
@fzr varchar(12)=null,
@fzr_tel varchar(20)=null,
@fzr_dy varchar(50)=null,
@bak_pay varchar(30)=null,
@bak_dress varchar(60)=null,
@date_bak datetime=null,
@fkqx varchar(20)=null,
@bz varchar(100)=null,
@customer_tel varchar(50)=null

AS
BEGIN
	insert into Customer values(@bh,@customer_num,@customer_name,@bm_dqfl,@address,@telephone_no,@mail,@contact_person,@contact_phone_no,@created_by,@created_date,@updated_by,@update_date,@status,@sales_person,@fzr_dz,@fax,@fzr,@fzr_tel,@fzr_dy,@bak_pay,@bak_dress,@date_bak,@fkqx,@bz,@customer_tel)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Customer_Delete

@bh varchar(18)

AS
BEGIN
	delete from Customer where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Customer_Change

@bh varchar(18),
@customer_num varchar(18),
@customer_name varchar(50)=null,
@bm_dqfl varchar(50)=null,
@address varchar(100)=null,
@telephone_no varchar(16)=null,
@mail varchar(16)=null,
@contact_person varchar(16)=null,
@contact_phone_no varchar(16)=null,
@created_by varchar(16)=null,
@created_date datetime=null,
@updated_by varchar(16)=null,
@update_date datetime=null,
@status varchar(1)=null,
@sales_person varchar(16)=null,
@fzr_dz char(60)=null,
@fax varchar(20)=null,
@fzr varchar(12)=null,
@fzr_tel varchar(20)=null,
@fzr_dy varchar(50)=null,
@bak_pay varchar(30)=null,
@bak_dress varchar(60)=null,
@date_bak datetime=null,
@fkqx varchar(20)=null,
@bz varchar(100)=null,
@customer_tel varchar(50)=null

AS
BEGIN
	update Customer set customer_num=@customer_num,customer_name=@customer_name,bm_dqfl=@bm_dqfl,address=@address,telephone_no=@telephone_no,mail=@mail,contact_person=@contact_person,contact_phone_no=@contact_phone_no,created_by=@created_by,created_date=@created_date,updated_by=@updated_by,update_date=@update_date,status=@status,sales_person=@sales_person,fzr_dz=@fzr_dz,fax=@fax,fzr=@fzr,fzr_tel=@fzr_tel,fzr_dy=@fzr_dy,bak_pay=@bak_pay,bak_dress=@bak_dress,date_bak=@date_bak,fkqx=@fkqx,bz=@bz,customer_tel=@customer_tel where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Customer_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Customer where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Customer_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Customer'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Customer_SelectAll
AS
BEGIN
	select * from Customer
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Pbcattbl_Add

@pbt_tnam char(30)=null,
@pbt_tid int=null,
@pbt_ownr char(30)=null,
@pbd_fhgt smallint=null,
@pbd_fwgt smallint=null,
@pbd_fitl char(1)=null,
@pbd_funl char(1)=null,
@pbd_fchr smallint=null,
@pbd_fptc smallint=null,
@pbd_ffce char(32)=null,
@pbh_fhgt smallint=null,
@pbh_fwgt smallint=null,
@pbh_fitl char(1)=null,
@pbh_funl char(1)=null,
@pbh_fchr smallint=null,
@pbh_fptc smallint=null,
@pbh_ffce char(32)=null,
@pbl_fhgt smallint=null,
@pbl_fwgt smallint=null,
@pbl_fitl char(1)=null,
@pbl_funl char(1)=null,
@pbl_fchr smallint=null,
@pbl_fptc smallint=null,
@pbl_ffce char(32)=null,
@pbt_cmnt varchar(254)=null

AS
BEGIN
if(@pbt_tid=0)
	begin
		set @pbt_tid=null
	end
	insert into Pbcattbl values(@pbt_tnam,@pbt_tid,@pbt_ownr,@pbd_fhgt,@pbd_fwgt,@pbd_fitl,@pbd_funl,@pbd_fchr,@pbd_fptc,@pbd_ffce,@pbh_fhgt,@pbh_fwgt,@pbh_fitl,@pbh_funl,@pbh_fchr,@pbh_fptc,@pbh_ffce,@pbl_fhgt,@pbl_fwgt,@pbl_fitl,@pbl_funl,@pbl_fchr,@pbl_fptc,@pbl_ffce,@pbt_cmnt)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Pbcattbl_Delete

@pbt_tnam char(30)

AS
BEGIN
	delete from Pbcattbl where pbt_tnam=@pbt_tnam
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Pbcattbl_Change

@pbt_tnam char(30)=null,
@pbt_tid int=null,
@pbt_ownr char(30)=null,
@pbd_fhgt smallint=null,
@pbd_fwgt smallint=null,
@pbd_fitl char(1)=null,
@pbd_funl char(1)=null,
@pbd_fchr smallint=null,
@pbd_fptc smallint=null,
@pbd_ffce char(32)=null,
@pbh_fhgt smallint=null,
@pbh_fwgt smallint=null,
@pbh_fitl char(1)=null,
@pbh_funl char(1)=null,
@pbh_fchr smallint=null,
@pbh_fptc smallint=null,
@pbh_ffce char(32)=null,
@pbl_fhgt smallint=null,
@pbl_fwgt smallint=null,
@pbl_fitl char(1)=null,
@pbl_funl char(1)=null,
@pbl_fchr smallint=null,
@pbl_fptc smallint=null,
@pbl_ffce char(32)=null,
@pbt_cmnt varchar(254)=null

AS
BEGIN
if(@pbt_tid=0)
	begin
		set @pbt_tid=null
	end
	update Pbcattbl set pbt_tid=@pbt_tid,pbt_ownr=@pbt_ownr,pbd_fhgt=@pbd_fhgt,pbd_fwgt=@pbd_fwgt,pbd_fitl=@pbd_fitl,pbd_funl=@pbd_funl,pbd_fchr=@pbd_fchr,pbd_fptc=@pbd_fptc,pbd_ffce=@pbd_ffce,pbh_fhgt=@pbh_fhgt,pbh_fwgt=@pbh_fwgt,pbh_fitl=@pbh_fitl,pbh_funl=@pbh_funl,pbh_fchr=@pbh_fchr,pbh_fptc=@pbh_fptc,pbh_ffce=@pbh_ffce,pbl_fhgt=@pbl_fhgt,pbl_fwgt=@pbl_fwgt,pbl_fitl=@pbl_fitl,pbl_funl=@pbl_funl,pbl_fchr=@pbl_fchr,pbl_fptc=@pbl_fptc,pbl_ffce=@pbl_ffce,pbt_cmnt=@pbt_cmnt where pbt_tnam=@pbt_tnam
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Pbcattbl_SelectById

@pbt_tnam char(30)=null

AS
BEGIN
	select * from Pbcattbl where pbt_tnam=@pbt_tnam
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Pbcattbl_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Pbcattbl'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Pbcattbl_SelectAll
AS
BEGIN
	select * from Pbcattbl
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatcol_Add

@pbc_tnam char(30)=null,
@pbc_tid int=null,
@pbc_ownr char(30)=null,
@pbc_cnam char(30)=null,
@pbc_cid smallint=null,
@pbc_labl varchar(254)=null,
@pbc_lpos smallint=null,
@pbc_hdr varchar(254)=null,
@pbc_hpos smallint=null,
@pbc_jtfy smallint=null,
@pbc_mask varchar(31)=null,
@pbc_case smallint=null,
@pbc_hght smallint=null,
@pbc_wdth smallint=null,
@pbc_ptrn varchar(31)=null,
@pbc_bmap char(1)=null,
@pbc_init varchar(254)=null,
@pbc_cmnt varchar(254)=null,
@pbc_edit varchar(31)=null,
@pbc_tag varchar(254)=null

AS
BEGIN
if(@pbc_tid=0)
	begin
		set @pbc_tid=null
	end
	insert into Pbcatcol values(@pbc_tnam,@pbc_tid,@pbc_ownr,@pbc_cnam,@pbc_cid,@pbc_labl,@pbc_lpos,@pbc_hdr,@pbc_hpos,@pbc_jtfy,@pbc_mask,@pbc_case,@pbc_hght,@pbc_wdth,@pbc_ptrn,@pbc_bmap,@pbc_init,@pbc_cmnt,@pbc_edit,@pbc_tag)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatcol_Delete

@pbc_tnam char(30)

AS
BEGIN
	delete from Pbcatcol where pbc_tnam=@pbc_tnam
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatcol_Change

@pbc_tnam char(30)=null,
@pbc_tid int=null,
@pbc_ownr char(30)=null,
@pbc_cnam char(30)=null,
@pbc_cid smallint=null,
@pbc_labl varchar(254)=null,
@pbc_lpos smallint=null,
@pbc_hdr varchar(254)=null,
@pbc_hpos smallint=null,
@pbc_jtfy smallint=null,
@pbc_mask varchar(31)=null,
@pbc_case smallint=null,
@pbc_hght smallint=null,
@pbc_wdth smallint=null,
@pbc_ptrn varchar(31)=null,
@pbc_bmap char(1)=null,
@pbc_init varchar(254)=null,
@pbc_cmnt varchar(254)=null,
@pbc_edit varchar(31)=null,
@pbc_tag varchar(254)=null

AS
BEGIN
if(@pbc_tid=0)
	begin
		set @pbc_tid=null
	end
	update Pbcatcol set pbc_tid=@pbc_tid,pbc_ownr=@pbc_ownr,pbc_cnam=@pbc_cnam,pbc_cid=@pbc_cid,pbc_labl=@pbc_labl,pbc_lpos=@pbc_lpos,pbc_hdr=@pbc_hdr,pbc_hpos=@pbc_hpos,pbc_jtfy=@pbc_jtfy,pbc_mask=@pbc_mask,pbc_case=@pbc_case,pbc_hght=@pbc_hght,pbc_wdth=@pbc_wdth,pbc_ptrn=@pbc_ptrn,pbc_bmap=@pbc_bmap,pbc_init=@pbc_init,pbc_cmnt=@pbc_cmnt,pbc_edit=@pbc_edit,pbc_tag=@pbc_tag where pbc_tnam=@pbc_tnam
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatcol_SelectById

@pbc_tnam char(30)=null

AS
BEGIN
	select * from Pbcatcol where pbc_tnam=@pbc_tnam
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatcol_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Pbcatcol'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatcol_SelectAll
AS
BEGIN
	select * from Pbcatcol
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatfmt_Add

@pbf_name varchar(30),
@pbf_frmt varchar(254),
@pbf_type smallint,
@pbf_cntr int=null

AS
BEGIN
if(@pbf_cntr=0)
	begin
		set @pbf_cntr=null
	end
	insert into Pbcatfmt values(@pbf_name,@pbf_frmt,@pbf_type,@pbf_cntr)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatfmt_Delete

@pbf_name varchar(30)

AS
BEGIN
	delete from Pbcatfmt where pbf_name=@pbf_name
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatfmt_Change

@pbf_name varchar(30),
@pbf_frmt varchar(254),
@pbf_type smallint,
@pbf_cntr int=null

AS
BEGIN
if(@pbf_cntr=0)
	begin
		set @pbf_cntr=null
	end
	update Pbcatfmt set pbf_frmt=@pbf_frmt,pbf_type=@pbf_type,pbf_cntr=@pbf_cntr where pbf_name=@pbf_name
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatfmt_SelectById

@pbf_name varchar(30)

AS
BEGIN
	select * from Pbcatfmt where pbf_name=@pbf_name
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatfmt_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Pbcatfmt'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatfmt_SelectAll
AS
BEGIN
	select * from Pbcatfmt
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Wast_user_Add

@bh varchar(18)=null,
@user_id varchar(20),
@user_name varchar(16)=null,
@group_id varchar(16)=null,
@password varchar(30)=null,
@pass_check varchar(30)=null,
@status int=null,
@last_in datetime=null,
@is_pos int=null,
@client_lr tinyint=null

AS
BEGIN
if(@status=0)
	begin
		set @status=null
	end
if(@is_pos=0)
	begin
		set @is_pos=null
	end
	insert into Wast_user values(@bh,@user_id,@user_name,@group_id,@password,@pass_check,@status,@last_in,@is_pos,@client_lr)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Wast_user_Delete

@bh varchar(18)

AS
BEGIN
	delete from Wast_user where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Wast_user_Change

@bh varchar(18)=null,
@user_id varchar(20),
@user_name varchar(16)=null,
@group_id varchar(16)=null,
@password varchar(30)=null,
@pass_check varchar(30)=null,
@status int=null,
@last_in datetime=null,
@is_pos int=null,
@client_lr tinyint=null

AS
BEGIN
if(@status=0)
	begin
		set @status=null
	end
if(@is_pos=0)
	begin
		set @is_pos=null
	end
	update Wast_user set user_id=@user_id,user_name=@user_name,group_id=@group_id,password=@password,pass_check=@pass_check,status=@status,last_in=@last_in,is_pos=@is_pos,client_lr=@client_lr where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Wast_user_SelectById

@bh varchar(18)=null

AS
BEGIN
	select * from Wast_user where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Wast_user_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Wast_user'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Wast_user_SelectAll
AS
BEGIN
	select * from Wast_user
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatvld_Add

@pbv_name varchar(30),
@pbv_vald varchar(254),
@pbv_type smallint,
@pbv_cntr int=null,
@pbv_msg varchar(254)=null

AS
BEGIN
if(@pbv_cntr=0)
	begin
		set @pbv_cntr=null
	end
	insert into Pbcatvld values(@pbv_name,@pbv_vald,@pbv_type,@pbv_cntr,@pbv_msg)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatvld_Delete

@pbv_name varchar(30)

AS
BEGIN
	delete from Pbcatvld where pbv_name=@pbv_name
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatvld_Change

@pbv_name varchar(30),
@pbv_vald varchar(254),
@pbv_type smallint,
@pbv_cntr int=null,
@pbv_msg varchar(254)=null

AS
BEGIN
if(@pbv_cntr=0)
	begin
		set @pbv_cntr=null
	end
	update Pbcatvld set pbv_vald=@pbv_vald,pbv_type=@pbv_type,pbv_cntr=@pbv_cntr,pbv_msg=@pbv_msg where pbv_name=@pbv_name
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatvld_SelectById

@pbv_name varchar(30)

AS
BEGIN
	select * from Pbcatvld where pbv_name=@pbv_name
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatvld_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Pbcatvld'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatvld_SelectAll
AS
BEGIN
	select * from Pbcatvld
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatedt_Add

@pbe_name varchar(30),
@pbe_edit varchar(254)=null,
@pbe_type smallint,
@pbe_cntr int=null,
@pbe_seqn smallint,
@pbe_flag int=null,
@pbe_work char(32)=null

AS
BEGIN
if(@pbe_cntr=0)
	begin
		set @pbe_cntr=null
	end
if(@pbe_flag=0)
	begin
		set @pbe_flag=null
	end
	insert into Pbcatedt values(@pbe_name,@pbe_edit,@pbe_type,@pbe_cntr,@pbe_seqn,@pbe_flag,@pbe_work)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatedt_Delete

@pbe_name varchar(30)

AS
BEGIN
	delete from Pbcatedt where pbe_name=@pbe_name
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatedt_Change

@pbe_name varchar(30),
@pbe_edit varchar(254)=null,
@pbe_type smallint,
@pbe_cntr int=null,
@pbe_seqn smallint,
@pbe_flag int=null,
@pbe_work char(32)=null

AS
BEGIN
if(@pbe_cntr=0)
	begin
		set @pbe_cntr=null
	end
if(@pbe_flag=0)
	begin
		set @pbe_flag=null
	end
	update Pbcatedt set pbe_edit=@pbe_edit,pbe_type=@pbe_type,pbe_cntr=@pbe_cntr,pbe_seqn=@pbe_seqn,pbe_flag=@pbe_flag,pbe_work=@pbe_work where pbe_name=@pbe_name
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatedt_SelectById

@pbe_name varchar(30)

AS
BEGIN
	select * from Pbcatedt where pbe_name=@pbe_name
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatedt_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Pbcatedt'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Pbcatedt_SelectAll
AS
BEGIN
	select * from Pbcatedt
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Wast_emplyee_Add

@bh varchar(16)=null,
@bm varchar(16),
@mc varchar(20)=null,
@bm_bm varchar(16)=null,
@sex varchar(2)=null,
@tel varchar(16)=null,
@birthday datetime=null,
@id_card varchar(20)=null,
@remark text=null,
@is_jbr tinyint=null,
@is_czy tinyint=null,
@rq_last_save_n int=null,
@jg varchar(40)=null,
@mz varchar(40)=null,
@xl varchar(20)=null,
@zc varchar(20)=null,
@is_married tinyint=null,
@dz varchar(150)=null,
@zzmm varchar(10)=null,
@birthday_nl varchar(30)=null,
@dz_home varchar(150)=null,
@mobile varchar(30)=null,
@qq varchar(50)=null,
@msn varchar(50)=null,
@email varchar(50)=null,
@rq_hire datetime=null,
@is_stop tinyint=null,
@rq_fire datetime=null,
@yy_fire varchar(200)=null

AS
BEGIN
if(@rq_last_save_n=0)
	begin
		set @rq_last_save_n=null
	end
	insert into Wast_emplyee values(@bh,@bm,@mc,@bm_bm,@sex,@tel,@birthday,@id_card,@remark,@is_jbr,@is_czy,@rq_last_save_n,@jg,@mz,@xl,@zc,@is_married,@dz,@zzmm,@birthday_nl,@dz_home,@mobile,@qq,@msn,@email,@rq_hire,@is_stop,@rq_fire,@yy_fire)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Wast_emplyee_Delete

@bh varchar(16)

AS
BEGIN
	delete from Wast_emplyee where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Wast_emplyee_Change

@bh varchar(16)=null,
@bm varchar(16),
@mc varchar(20)=null,
@bm_bm varchar(16)=null,
@sex varchar(2)=null,
@tel varchar(16)=null,
@birthday datetime=null,
@id_card varchar(20)=null,
@remark text=null,
@is_jbr tinyint=null,
@is_czy tinyint=null,
@rq_last_save_n int=null,
@jg varchar(40)=null,
@mz varchar(40)=null,
@xl varchar(20)=null,
@zc varchar(20)=null,
@is_married tinyint=null,
@dz varchar(150)=null,
@zzmm varchar(10)=null,
@birthday_nl varchar(30)=null,
@dz_home varchar(150)=null,
@mobile varchar(30)=null,
@qq varchar(50)=null,
@msn varchar(50)=null,
@email varchar(50)=null,
@rq_hire datetime=null,
@is_stop tinyint=null,
@rq_fire datetime=null,
@yy_fire varchar(200)=null

AS
BEGIN
if(@rq_last_save_n=0)
	begin
		set @rq_last_save_n=null
	end
	update Wast_emplyee set bm=@bm,mc=@mc,bm_bm=@bm_bm,sex=@sex,tel=@tel,birthday=@birthday,id_card=@id_card,remark=@remark,is_jbr=@is_jbr,is_czy=@is_czy,rq_last_save_n=@rq_last_save_n,jg=@jg,mz=@mz,xl=@xl,zc=@zc,is_married=@is_married,dz=@dz,zzmm=@zzmm,birthday_nl=@birthday_nl,dz_home=@dz_home,mobile=@mobile,qq=@qq,msn=@msn,email=@email,rq_hire=@rq_hire,is_stop=@is_stop,rq_fire=@rq_fire,yy_fire=@yy_fire where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Wast_emplyee_SelectById

@bh varchar(16)=null

AS
BEGIN
	select * from Wast_emplyee where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Wast_emplyee_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Wast_emplyee'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Wast_emplyee_SelectAll
AS
BEGIN
	select * from Wast_emplyee
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Lock_row_Add

@windowname varchar(60)=null,
@bh varchar(18),
@username varchar(30)=null,
@row tinyint=null,
@xh tinyint=null

AS
BEGIN
	insert into Lock_row values(@windowname,@bh,@username,@row,@xh)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Lock_row_Delete

@windowname varchar(60)

AS
BEGIN
	delete from Lock_row where windowname=@windowname
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Lock_row_Change

@windowname varchar(60)=null,
@bh varchar(18),
@username varchar(30)=null,
@row tinyint=null,
@xh tinyint=null

AS
BEGIN
	update Lock_row set bh=@bh,username=@username,row=@row,xh=@xh where windowname=@windowname
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Lock_row_SelectById

@windowname varchar(60)=null

AS
BEGIN
	select * from Lock_row where windowname=@windowname
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Lock_row_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Lock_row'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Lock_row_SelectAll
AS
BEGIN
	select * from Lock_row
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE System_config_Add

@dbver varchar(12)=null,
@update_date datetime=null,
@exit_backup tinyint=null,
@check_status char(8)=null,
@is_cal tinyint=null,
@backup_dir varchar(200)=null,
@waste_n tinyint=null,
@edit_sh tinyint=null,
@sample_bh tinyint=null,
@c1 tinyint=null,
@c2 tinyint=null,
@c3 tinyint=null,
@c4 tinyint=null,
@c5 tinyint=null,
@com varchar(18)=null,
@pt varchar(12)=null,
@sjw varchar(12)=null,
@tzw varchar(12)=null,
@xyw varchar(12)=null,
@ftp_server varchar(60)=null,
@ftp_com varchar(18)=null,
@ftp_user varchar(30)=null,
@ftp_password varchar(30)=null,
@BBH varchar(30)=null,
@times tinyint=null

AS
BEGIN
	insert into System_config values(@dbver,@update_date,@exit_backup,@check_status,@is_cal,@backup_dir,@waste_n,@edit_sh,@sample_bh,@c1,@c2,@c3,@c4,@c5,@com,@pt,@sjw,@tzw,@xyw,@ftp_server,@ftp_com,@ftp_user,@ftp_password,@BBH,@times)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE System_config_Delete

@dbver varchar(12)

AS
BEGIN
	delete from System_config where dbver=@dbver
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE System_config_Change

@dbver varchar(12)=null,
@update_date datetime=null,
@exit_backup tinyint=null,
@check_status char(8)=null,
@is_cal tinyint=null,
@backup_dir varchar(200)=null,
@waste_n tinyint=null,
@edit_sh tinyint=null,
@sample_bh tinyint=null,
@c1 tinyint=null,
@c2 tinyint=null,
@c3 tinyint=null,
@c4 tinyint=null,
@c5 tinyint=null,
@com varchar(18)=null,
@pt varchar(12)=null,
@sjw varchar(12)=null,
@tzw varchar(12)=null,
@xyw varchar(12)=null,
@ftp_server varchar(60)=null,
@ftp_com varchar(18)=null,
@ftp_user varchar(30)=null,
@ftp_password varchar(30)=null,
@BBH varchar(30)=null,
@times tinyint=null

AS
BEGIN
	update System_config set update_date=@update_date,exit_backup=@exit_backup,check_status=@check_status,is_cal=@is_cal,backup_dir=@backup_dir,waste_n=@waste_n,edit_sh=@edit_sh,sample_bh=@sample_bh,c1=@c1,c2=@c2,c3=@c3,c4=@c4,c5=@c5,com=@com,pt=@pt,sjw=@sjw,tzw=@tzw,xyw=@xyw,ftp_server=@ftp_server,ftp_com=@ftp_com,ftp_user=@ftp_user,ftp_password=@ftp_password,BBH=@BBH,times=@times where dbver=@dbver
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE System_config_SelectById

@dbver varchar(12)=null

AS
BEGIN
	select * from System_config where dbver=@dbver
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE System_config_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from System_config'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE System_config_SelectAll
AS
BEGIN
	select * from System_config
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_edit_record_Add

@ticket_num varchar(18)=null,
@edited_by varchar(18)=null,
@edit_date datetime=null,
@sl int,
@is_begian tinyint

AS
BEGIN
	insert into Ticket_edit_record values(@ticket_num,@edited_by,@edit_date,@sl,@is_begian)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_edit_record_Delete

@bm int

AS
BEGIN
	delete from Ticket_edit_record where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_edit_record_Change

@bm int,
@ticket_num varchar(18)=null,
@edited_by varchar(18)=null,
@edit_date datetime=null,
@sl int,
@is_begian tinyint

AS
BEGIN
	update Ticket_edit_record set ticket_num=@ticket_num,edited_by=@edited_by,edit_date=@edit_date,sl=@sl,is_begian=@is_begian where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_edit_record_SelectById

@bm int

AS
BEGIN
	select * from Ticket_edit_record where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_edit_record_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Ticket_edit_record'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_edit_record_SelectAll
AS
BEGIN
	select * from Ticket_edit_record
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Color_Add

@bm varchar(18),
@mc varchar(30)=null

AS
BEGIN
	insert into Color values(@bm,@mc)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Color_Delete

@bm varchar(18)

AS
BEGIN
	delete from Color where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Color_Change

@bm varchar(18),
@mc varchar(30)=null

AS
BEGIN
	update Color set mc=@mc where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Color_SelectById

@bm varchar(18)

AS
BEGIN
	select * from Color where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Color_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Color'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Color_SelectAll
AS
BEGIN
	select * from Color
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Net_computer_Add

@computer_ip varchar(16)=null,
@computer_name varchar(50)=null,
@is_connect tinyint=null,
@is_net varchar(30)=null,
@computer_type char(10)=null

AS
BEGIN
	insert into Net_computer values(@computer_ip,@computer_name,@is_connect,@is_net,@computer_type)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Net_computer_Delete

@computer_ip varchar(16)

AS
BEGIN
	delete from Net_computer where computer_ip=@computer_ip
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Net_computer_Change

@computer_ip varchar(16)=null,
@computer_name varchar(50)=null,
@is_connect tinyint=null,
@is_net varchar(30)=null,
@computer_type char(10)=null

AS
BEGIN
	update Net_computer set computer_name=@computer_name,is_connect=@is_connect,is_net=@is_net,computer_type=@computer_type where computer_ip=@computer_ip
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Net_computer_SelectById

@computer_ip varchar(16)=null

AS
BEGIN
	select * from Net_computer where computer_ip=@computer_ip
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Net_computer_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Net_computer'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Net_computer_SelectAll
AS
BEGIN
	select * from Net_computer
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Color_group_Add

@bm varchar(18),
@mc varchar(30)=null,
@color_id varchar(18),
@status tinyint=null

AS
BEGIN
	insert into Color_group values(@bm,@mc,@color_id,@status)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Color_group_Delete

@bm varchar(18)

AS
BEGIN
	delete from Color_group where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Color_group_Change

@bm varchar(18),
@mc varchar(30)=null,
@color_id varchar(18),
@status tinyint=null

AS
BEGIN
	update Color_group set mc=@mc,color_id=@color_id,status=@status where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Color_group_SelectById

@bm varchar(18)

AS
BEGIN
	select * from Color_group where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Color_group_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Color_group'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Color_group_SelectAll
AS
BEGIN
	select * from Color_group
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_record_Add

@bh varchar(18)=null,
@ticket_num varchar(18),
@customer_num varchar(18)=null,
@waste_id varchar(18)=null,
@collector_num varchar(18)=null,
@vehicle_num varchar(18)=null,
@driver_name varchar(16)=null,
@delivery_date datetime=null,
@start_point varchar(40)=null,
@end_point varchar(40)=null,
@created_by varchar(16)=null,
@create_date datetime=null,
@updated_by varchar(16)=null,
@update_date datetime=null,
@total_weight decimal=null,
@sl int=null,
@fyr varchar(12)=null,
@move_to varchar(100)=null,
@rq_yc datetime=null,
@rq_ys datetime=null,
@fzr varchar(12)=null,
@rq_js datetime=null,
@cyr varchar(12)=null,
@year_yc char(4)=null,
@month_yc char(2)=null,
@day_yc char(2)=null,
@year_ys char(4)=null,
@month_ys char(2)=null,
@day_ys char(2)=null,
@year_js char(4)=null,
@month_js char(2)=null,
@day_js char(2)=null,
@status char(5)=null,
@is_cell tinyint=null,
@is_print tinyint=null,
@barcode varchar(400)=null,
@bar_sl int=null

AS
BEGIN
if(@sl=0)
	begin
		set @sl=null
	end
if(@bar_sl=0)
	begin
		set @bar_sl=null
	end
	insert into Ticket_record values(@bh,@ticket_num,@customer_num,@waste_id,@collector_num,@vehicle_num,@driver_name,@delivery_date,@start_point,@end_point,@created_by,@create_date,@updated_by,@update_date,@total_weight,@sl,@fyr,@move_to,@rq_yc,@rq_ys,@fzr,@rq_js,@cyr,@year_yc,@month_yc,@day_yc,@year_ys,@month_ys,@day_ys,@year_js,@month_js,@day_js,@status,@is_cell,@is_print,@barcode,@bar_sl)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_record_Delete

@bh varchar(18)

AS
BEGIN
	delete from Ticket_record where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_record_Change

@bh varchar(18)=null,
@ticket_num varchar(18),
@customer_num varchar(18)=null,
@waste_id varchar(18)=null,
@collector_num varchar(18)=null,
@vehicle_num varchar(18)=null,
@driver_name varchar(16)=null,
@delivery_date datetime=null,
@start_point varchar(40)=null,
@end_point varchar(40)=null,
@created_by varchar(16)=null,
@create_date datetime=null,
@updated_by varchar(16)=null,
@update_date datetime=null,
@total_weight decimal=null,
@sl int=null,
@fyr varchar(12)=null,
@move_to varchar(100)=null,
@rq_yc datetime=null,
@rq_ys datetime=null,
@fzr varchar(12)=null,
@rq_js datetime=null,
@cyr varchar(12)=null,
@year_yc char(4)=null,
@month_yc char(2)=null,
@day_yc char(2)=null,
@year_ys char(4)=null,
@month_ys char(2)=null,
@day_ys char(2)=null,
@year_js char(4)=null,
@month_js char(2)=null,
@day_js char(2)=null,
@status char(5)=null,
@is_cell tinyint=null,
@is_print tinyint=null,
@barcode varchar(400)=null,
@bar_sl int=null

AS
BEGIN
if(@sl=0)
	begin
		set @sl=null
	end
if(@bar_sl=0)
	begin
		set @bar_sl=null
	end
	update Ticket_record set ticket_num=@ticket_num,customer_num=@customer_num,waste_id=@waste_id,collector_num=@collector_num,vehicle_num=@vehicle_num,driver_name=@driver_name,delivery_date=@delivery_date,start_point=@start_point,end_point=@end_point,created_by=@created_by,create_date=@create_date,updated_by=@updated_by,update_date=@update_date,total_weight=@total_weight,sl=@sl,fyr=@fyr,move_to=@move_to,rq_yc=@rq_yc,rq_ys=@rq_ys,fzr=@fzr,rq_js=@rq_js,cyr=@cyr,year_yc=@year_yc,month_yc=@month_yc,day_yc=@day_yc,year_ys=@year_ys,month_ys=@month_ys,day_ys=@day_ys,year_js=@year_js,month_js=@month_js,day_js=@day_js,status=@status,is_cell=@is_cell,is_print=@is_print,barcode=@barcode,bar_sl=@bar_sl where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_record_SelectById

@bh varchar(18)=null

AS
BEGIN
	select * from Ticket_record where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_record_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Ticket_record'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Ticket_record_SelectAll
AS
BEGIN
	select * from Ticket_record
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Delete_record_Add

@delete_sql varchar(500)=null,
@bh varchar(20)=null,
@deleted_by varchar(12)=null,
@delete_date datetime=null,
@djlx varchar(12)=null

AS
BEGIN
	insert into Delete_record values(@delete_sql,@bh,@deleted_by,@delete_date,@djlx)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Delete_record_Delete

@delete_sql varchar(500)

AS
BEGIN
	delete from Delete_record where delete_sql=@delete_sql
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Delete_record_Change

@delete_sql varchar(500)=null,
@bh varchar(20)=null,
@deleted_by varchar(12)=null,
@delete_date datetime=null,
@djlx varchar(12)=null

AS
BEGIN
	update Delete_record set bh=@bh,deleted_by=@deleted_by,delete_date=@delete_date,djlx=@djlx where delete_sql=@delete_sql
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Delete_record_SelectById

@delete_sql varchar(500)=null

AS
BEGIN
	select * from Delete_record where delete_sql=@delete_sql
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Delete_record_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Delete_record'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Delete_record_SelectAll
AS
BEGIN
	select * from Delete_record
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Samples_unsh_record_Add

@samples_id varchar(18)=null,
@unsh_by varchar(18)=null,
@unsh_date datetime=null,
@bz varchar(100)=null

AS
BEGIN
	insert into Samples_unsh_record values(@samples_id,@unsh_by,@unsh_date,@bz)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Samples_unsh_record_Delete

@bm int

AS
BEGIN
	delete from Samples_unsh_record where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Samples_unsh_record_Change

@bm int,
@samples_id varchar(18)=null,
@unsh_by varchar(18)=null,
@unsh_date datetime=null,
@bz varchar(100)=null

AS
BEGIN
	update Samples_unsh_record set samples_id=@samples_id,unsh_by=@unsh_by,unsh_date=@unsh_date,bz=@bz where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_unsh_record_SelectById

@bm int

AS
BEGIN
	select * from Samples_unsh_record where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_unsh_record_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Samples_unsh_record'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_unsh_record_SelectAll
AS
BEGIN
	select * from Samples_unsh_record
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Samples_matter_Add

@bm varchar(18),
@mc varchar(30)=null

AS
BEGIN
	insert into Samples_matter values(@bm,@mc)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Samples_matter_Delete

@bm varchar(18)

AS
BEGIN
	delete from Samples_matter where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Samples_matter_Change

@bm varchar(18),
@mc varchar(30)=null

AS
BEGIN
	update Samples_matter set mc=@mc where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_matter_SelectById

@bm varchar(18)

AS
BEGIN
	select * from Samples_matter where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_matter_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Samples_matter'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Samples_matter_SelectAll
AS
BEGIN
	select * from Samples_matter
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Component_wltx_Add

@component_type varchar(18)=null,
@bm varchar(18)=null,
@mc varchar(18)=null

AS
BEGIN
	insert into Component_wltx values(@component_type,@bm,@mc)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Component_wltx_Delete

@bh int

AS
BEGIN
	delete from Component_wltx where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Component_wltx_Change

@bh int,
@component_type varchar(18)=null,
@bm varchar(18)=null,
@mc varchar(18)=null

AS
BEGIN
	update Component_wltx set component_type=@component_type,bm=@bm,mc=@mc where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Component_wltx_SelectById

@bh int

AS
BEGIN
	select * from Component_wltx where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Component_wltx_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Component_wltx'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Component_wltx_SelectAll
AS
BEGIN
	select * from Component_wltx
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Process_Add

@bm varchar(18),
@mc varchar(40)=null,
@process varchar(160),
@color char(18)=null,
@clfs varchar(60)=null,
@bz varchar(100)=null

AS
BEGIN
	insert into Process values(@bm,@mc,@process,@color,@clfs,@bz)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Process_Delete

@bm varchar(18)

AS
BEGIN
	delete from Process where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Process_Change

@bm varchar(18),
@mc varchar(40)=null,
@process varchar(160),
@color char(18)=null,
@clfs varchar(60)=null,
@bz varchar(100)=null

AS
BEGIN
	update Process set mc=@mc,process=@process,color=@color,clfs=@clfs,bz=@bz where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Process_SelectById

@bm varchar(18)

AS
BEGIN
	select * from Process where bm=@bm
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Process_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Process'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Process_SelectAll
AS
BEGIN
	select * from Process
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Component_wltx_type_Add

@component_type varchar(18)=null,
@mc varchar(18)=null

AS
BEGIN
	insert into Component_wltx_type values(@component_type,@mc)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Component_wltx_type_Delete

@bh int

AS
BEGIN
	delete from Component_wltx_type where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Component_wltx_type_Change

@bh int,
@component_type varchar(18)=null,
@mc varchar(18)=null

AS
BEGIN
	update Component_wltx_type set component_type=@component_type,mc=@mc where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Component_wltx_type_SelectById

@bh int

AS
BEGIN
	select * from Component_wltx_type where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Component_wltx_type_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Component_wltx_type'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Component_wltx_type_SelectAll
AS
BEGIN
	select * from Component_wltx_type
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Dtproperties_Add

@objectid int=null,
@property varchar(64),
@value varchar(255)=null,
@uvalue nvarchar(510)=null,
@lvalue image=null,
@version int

AS
BEGIN
if(@objectid=0)
	begin
		set @objectid=null
	end
	insert into Dtproperties values(@objectid,@property,@value,@uvalue,@lvalue,@version)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Dtproperties_Delete

@id int

AS
BEGIN
	delete from Dtproperties where id=@id
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Dtproperties_Change

@id int,
@objectid int=null,
@property varchar(64),
@value varchar(255)=null,
@uvalue nvarchar(510)=null,
@lvalue image=null,
@version int

AS
BEGIN
if(@objectid=0)
	begin
		set @objectid=null
	end
	update Dtproperties set objectid=@objectid,property=@property,value=@value,uvalue=@uvalue,lvalue=@lvalue,version=@version where id=@id
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Dtproperties_SelectById

@id int

AS
BEGIN
	select * from Dtproperties where id=@id
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Dtproperties_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Dtproperties'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Dtproperties_SelectAll
AS
BEGIN
	select * from Dtproperties
END
GO


-- ===============================================================================================================================================


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:增加<Description,,>
-- =============================================
CREATE PROCEDURE Laboratory_Add

@bh varchar(18),
@bm varchar(18),
@mc varchar(40)=null

AS
BEGIN
	insert into Laboratory values(@bh,@bm,@mc)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:删除<Description,,>
-- =============================================
CREATE PROCEDURE Laboratory_Delete

@bh varchar(18)

AS
BEGIN
	delete from Laboratory where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:修改<Description,,>
-- =============================================
CREATE PROCEDURE Laboratory_Change

@bh varchar(18),
@bm varchar(18),
@mc varchar(40)=null

AS
BEGIN
	update Laboratory set bm=@bm,mc=@mc where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过ID查询<Description,,>
-- =============================================
CREATE PROCEDURE Laboratory_SelectById

@bh varchar(18)

AS
BEGIN
	select * from Laboratory where bh=@bh
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:通过条件查询<Description,,>
-- =============================================
CREATE PROCEDURE Laboratory_SelectByWhere

@where varchar(200)

AS
BEGIN
	declare @String varchar(200)
	set @String='select * from Laboratory'+ @where
	exec(@String)
END
GO


-- =============================================
-- Author:admin<Author,,Name>
-- Create date: 2016/3/14<Create Date,,>
-- Description:全部查询<Description,,>
-- =============================================
CREATE PROCEDURE Laboratory_SelectAll
AS
BEGIN
	select * from Laboratory
END
GO


-- ===============================================================================================================================================



