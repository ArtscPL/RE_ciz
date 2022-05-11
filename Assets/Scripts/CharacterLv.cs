using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLv : MonoBehaviour
{
    //public int playerExp=0;
    public int BaseHP;
    public int BaseDEF;
    public int BaseEVA;
    public int BaseRES;

    public int levelCalculator(int Exp){
        int lv = 1;
        if(Exp>=20100){
            lv = 30;
        }
        else if(Exp>=17100 && Exp<20100){
            lv = 29;
        }
        else if(Exp>=15900 && Exp<17100){
            lv = 28;
        }
        else if(Exp>=14800 && Exp<15900){
            lv = 27;
        }
        else if(Exp>=13700 && Exp<14800){
            lv = 26;
        }
        else if(Exp>=12600 && Exp<13700){
            lv = 25;
        }
        else if(Exp>=11600 && Exp<12600){
            lv = 24;
        }
        else if(Exp>=10600 && Exp<11600){
            lv = 23;
        }
        else if(Exp>=9600 && Exp<10600){
            lv = 22;
        }
        else if(Exp>=8800 && Exp<9600){
            lv = 21;
        }
        else if(Exp>=8000 && Exp<8800){
            lv = 20;
        }
        else if(Exp>=7200 && Exp<8000){
            lv = 19;
        }
        else if(Exp>=6500 && Exp<7200){
            lv = 18;
        }
        else if(Exp>=5800 && Exp<6500){
            lv = 17;
        }
        else if(Exp>=5100 && Exp<5800){
            lv = 16;
        }
        else if(Exp>=4500 && Exp<5100){
            lv = 15;
        }
        else if(Exp>=3900 && Exp<4500){
            lv = 14;
        }
        else if(Exp>=3300 && Exp<3900){
            lv = 13;
        }
        else if(Exp>=2800 && Exp<3300){
            lv = 12;
        }
        else if(Exp>=2300 && Exp<2800){
            lv = 11;
        }
        else if(Exp>=1800 && Exp<2300){
            lv = 10;
        }
        else if(Exp>=1500 && Exp<1800){
            lv = 9;
        }
        else if(Exp>=1200 && Exp<1500){
            lv = 8;
        }
        else if(Exp>=900 && Exp<1200){
            lv = 7;
        }
        else if(Exp>=700 && Exp<900){
            lv = 6;
        }
        else if(Exp>=500 && Exp<700){
            lv = 5;
        }
        else if(Exp>=300 && Exp<500){
            lv = 4;
        }
        else if(Exp>=200 && Exp<300){
            lv = 3;
        }
        else if(Exp>=100 && Exp<200){
            lv = 2;
        }
        else{
            lv=1;
        }

        return lv;
    }

    public void GetBaseSTAT(int lv){
        if(lv==1){
            BaseHP = 500;
            BaseDEF = 0;
            BaseEVA = 0;
            BaseRES = 0;
        }
        else if(lv==2){
            BaseHP = 510;
            BaseDEF = 0;
            BaseEVA = 0;
            BaseRES = 0;
        }
        else if(lv==3){
            BaseHP = 520;
            BaseDEF = 0;
            BaseEVA = 0;
            BaseRES = 0;
        }
        else if(lv==4){
            BaseHP = 530;
            BaseDEF = 0;
            BaseEVA = 0;
            BaseRES = 0;
        }
        else if(lv==5){
            BaseHP = 540;
            BaseDEF = 0;
            BaseEVA = 0;
            BaseRES = 0;
        }
        else if(lv==6){
            BaseHP = 550;
            BaseDEF = 0;
            BaseEVA = 0;
            BaseRES = 0;
        }
        else if(lv==7){
            BaseHP = 560;
            BaseDEF = 0;
            BaseEVA = 0;
            BaseRES = 0;
        }
        else if(lv==8){
            BaseHP = 570;
            BaseDEF = 0;
            BaseEVA = 0;
            BaseRES = 0;
        }
        else if(lv==9){
            BaseHP = 580;
            BaseDEF = 0;
            BaseEVA = 0;
            BaseRES = 0;
        }
        else if(lv==10){
            BaseHP = 600;
            BaseDEF = 0;
            BaseEVA = 5;
            BaseRES = 0;
        }
        else if(lv==11){
            BaseHP = 620;
            BaseDEF = 50;
            BaseEVA = 5;
            BaseRES = 0;
        }
        else if(lv==12){
            BaseHP = 640;
            BaseDEF = 100;
            BaseEVA = 5;
            BaseRES = 0;
        }
        else if(lv==13){
            BaseHP = 660;
            BaseDEF = 150;
            BaseEVA = 5;
            BaseRES = 0;
        }
        else if(lv==14){
            BaseHP = 680;
            BaseDEF = 200;
            BaseEVA = 5;
            BaseRES = 0;
        }
        else if(lv==15){
            BaseHP = 700;
            BaseDEF = 250;
            BaseEVA = 5;
            BaseRES = 0;
        }
        else if(lv==16){
            BaseHP = 720;
            BaseDEF = 300;
            BaseEVA = 5;
            BaseRES = 0;
        }
        else if(lv==17){
            BaseHP = 740;
            BaseDEF = 350;
            BaseEVA = 5;
            BaseRES = 0;
        }
        else if(lv==18){
            BaseHP = 760;
            BaseDEF = 400;
            BaseEVA = 5;
            BaseRES = 0;
        }
        else if(lv==19){
            BaseHP = 780;
            BaseDEF = 450;
            BaseEVA = 5;
            BaseRES = 0;
        }
        else if(lv==20){
            BaseHP = 800;
            BaseDEF = 500;
            BaseEVA = 10;
            BaseRES = 0;
        }
        else if(lv==21){
            BaseHP = 820;
            BaseDEF = 550;
            BaseEVA = 10;
            BaseRES = 0;
        }
        else if(lv==22){
            BaseHP = 840;
            BaseDEF = 600;
            BaseEVA = 10;
            BaseRES = 0;
        }
        else if(lv==23){
            BaseHP = 860;
            BaseDEF = 650;
            BaseEVA = 10;
            BaseRES = 0;
        }
        else if(lv==24){
            BaseHP = 880;
            BaseDEF = 700;
            BaseEVA = 10;
            BaseRES = 0;
        }
        else if(lv==25){
            BaseHP = 900;
            BaseDEF = 750;
            BaseEVA = 10;
            BaseRES = 0;
        }
        else if(lv==26){
            BaseHP = 920;
            BaseDEF = 800;
            BaseEVA = 10;
            BaseRES = 0;
        }
        else if(lv==27){
            BaseHP = 940;
            BaseDEF = 850;
            BaseEVA = 10;
            BaseRES = 0;
        }
        else if(lv==28){
            BaseHP = 960;
            BaseDEF = 900;
            BaseEVA = 10;
            BaseRES = 0;
        }
        else if(lv==29){
            BaseHP = 980;
            BaseDEF = 950;
            BaseEVA = 10;
            BaseRES = 0;
        }
        else if(lv==30){
            BaseHP = 1000;
            BaseDEF = 1000;
            BaseEVA = 15;
            BaseRES = 15;
        }
    }
}
