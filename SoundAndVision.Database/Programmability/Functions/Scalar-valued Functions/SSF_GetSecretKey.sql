﻿CREATE FUNCTION [dbo].[SSF_GetSecretKey]()

RETURNS NVARCHAR(2048)
AS
BEGIN
	DECLARE @Key NVARCHAR(2048);

	SET @Key = N'SNA305L$OOB-$Od;9km(k\zwN|8Vn\=&;ou-;N"9qPn6[M<f!Qic=,%Lb+b"P]&"6ZBO/0uZmdY+mH3alBXL"/BUhA4/IhE9e1s2RpH9.B?u4y3UTC)WIvuh3L)L,R+d$|zCQ5,554Nu2wOIwM%iP(i#}96&S<~rc)^,w,l>B>2-Wdf|fhV*2nPnVf[]?+;w}.aNF}Ts/P$<<~v9y!>;A|~w#`G:XA;)+%nC(l=C4(?/"z"`W`.W-gwJ57Ko:}g*GPpr|.3j,Z\%)fn{)LKz*gPW}P=5vYn"d?a1}DDqX.(WZaV>)qiW=&"t.p=Si+9[t#tRa?mjm`GaDKkj1{vG9i}7pr@%mk<pVHAj+:HxhmO>ji!vTH4MxqRpkBD^BPp3L{&#m"(;+]W$kH$p,!^P~oS+l|\-\Phmc;h"y(FwLS:y^Wz@6Ixd"N&>rxD~h~jv>Bu_Cm5&B$3D8u-pjh%S_1!25ToM6,tFIsWALB|[$K_oCB^"*uth#JmGtFQn]DH?JW%hC^vjCI~WE%6J|gvqt"Z2vi7c(j]r^mBwrm`nM7C1qN{#&m4OeD~VKDR9Ci>IMf|;~x~n(0~U.`;\po"k7AuRZ{!<4>6vHPYGc;yeO|F;^!B#+U[<Ak2aaC<uH%\u(.g^e<VF\2uY+g?fp|iqBRG&@C}0ge;O%NezZ"[0@X5Itw?nHHLT3/{)bS~QQjd@^"cEy<wB"lczl*1`-6luz5=EdTQ*b<=/jsZ8q!M[:%y{F+zTT)eB\Z!37qE0dl2E]H%7boG2A84g2$`\vAF)3CHT-.gzNo0Lyq.8lqjC]"SpkEO69ye)SGke4*)t|M~|Ik1Th|XAH?fUlQ|V<k#{PA@Tp$n0xoGv{go#0\Ra0?Kk\G:bUAHUa|cC?yK-DLkq1[zH3?Po#`PAM6f(u,7?kQVQd3?92}bcd~A<^M!E2Cci"|x#5Q-&`G+|Bbsz&<qddQ;R@q(D]"4BtTU83lN~:[@7=ZJ.5@,:u[MVP2Q2}USU?!L]jM&YnEn[EU6en1,:XZlhpAD#8hK]|@k|V1N_[dG{PeG|y~Z2r%S*}t31D0d3X^zEwFIwl;|5A/,=h6m+j|?Y"Jkpu:`HQE#;"B}=&&}sLyr1uwSkHLju7(:vFf2l6WzFK:WuOpucOx&TPA"tbo2LLrGTFv^E,T5nA}4HYwPOnnFs@b6!ftq`{71;uqta![Jum3nRMGMA%w&nL<Mk%4Fex`BZ]2!B/{>iTo&{9Y2CPhVn[2%ZjUyO>ht`kGx}lu|c^\oCPjh\f6XD9/@t4$=[(5cuhl`235^w{D$G|)|h|[HCYGzK\?Mu,kC,s*3Bo"2v*5IY%!"4rvYwJADq&&*~a@Q8RHD^U7j31l^D|)-]NqOz1P)np}k"~KLoX|w\Rg)8JAK]AQy&V|D@sZ>2(;)!ERor0TK:oCRLv{YTJQ-D|DE;(0"*`GTe}k-av`.y.pYbpNo/7sBFjEl#x)\j!E{x~3+"|jLBd_+rR!6@bl5qij~z7F7/+?as&I9Hhw!w)?u(7JjSB<nmM8wP|j>R._+|??1l$rN>LiVT.''7?,iPdllOV/J8J!d<]W*pWk|#y}U!S921t{<6DfkxfOlX$P.&MFT+v-hdR%\rf5N?{#pYZDm7~Nlj?&Dz+C]IO=06}_@N/j#]PnScZ08(YB?}M^/flJJ@vp<v7lsPoLR/P?bl|^C*ph8zHHXf!-~VT6LMJWEa.#iwaW/7PS?\ynUz{Rd<RVe">ampND9b(67Pd9>NhYi%_i:_=xYpG=-<IY=IO%Dt!4wBXQ@jx7[NH}|V1#1!_8^n8[tgF+GMU)msx24$p."*vc![UmuY_x(5B{4e?J#DsxY\chZ-4`_88%#"On=MC1laPS8w@XI>"Os6\/ZlD)cV3K[P.=(Zy*Z7lpd6^>C6=f"*;+fxWl@I<U11}t[AXu"bwPA>R5%l%Ica-"*k,30sHzI4NXO{6z}mE;oZmqefK%dU,|VMuJ#P2oq^q~$az:Pz=SCB^04-4$M0R}1#o=Xi|C!S!pG"uk&`Io4cpQ$@`iuX%5LDZv$Bsh~z';

	RETURN @Key;
END