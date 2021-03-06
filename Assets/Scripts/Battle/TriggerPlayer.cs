using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerPlayer : MonoBehaviour
{
    public int enemyAssignedID;
    public GameObject thisEnemy;
    public int MoveTo;
    private void OnTriggerEnter(Collider other) 
    {
        MoveData.enemyPrefabs = thisEnemy;
        if (other.CompareTag("Player"))
        {
            findingNemo();
            MoveData.MoveCalled++;
            SaveManager.GetInstance().SavetoAsset();
            SaveManager.GetInstance().SaveGameData();
            Destroy(gameObject);
            SceneManager.LoadScene(MoveTo);
        }
    }

    private void findingNemo(){
        string nani = SceneManager.GetActiveScene().name;
        if(nani == "Centriana"){
            switch(enemyAssignedID){
                case 1:
                    SaveManager.GetInstance().SavePositionX = (float)4.485672;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)-2.43298459;
                    break;
                case 2:
                    SaveManager.GetInstance().SavePositionX = (float)11.9543495;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)3.93559051;
                    break;
                case 3:
                    SaveManager.GetInstance().SavePositionX = (float)16.2597866;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)1.36305106;
                    break;
                case 4:
                    SaveManager.GetInstance().SavePositionX = (float)6.15447998;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)1.43352604;
                    break;
                default:
                break;
            }
        }
        else if(nani == "Slopakia"){
            switch(enemyAssignedID){
                case 1:
                    SaveManager.GetInstance().SavePositionX = (float)-12.7925701;
                    SaveManager.GetInstance().SavePositionY = (float)0.247500002;
                    SaveManager.GetInstance().SavePositionZ = (float)-2.02052832;
                    break;
                case 2:
                    SaveManager.GetInstance().SavePositionX = (float)-7.96460485;
                    SaveManager.GetInstance().SavePositionY = (float)0.247500002;
                    SaveManager.GetInstance().SavePositionZ = (float)3.22201991;
                    break;
                case 3:
                    SaveManager.GetInstance().SavePositionX = (float)-3.10489035;
                    SaveManager.GetInstance().SavePositionY = (float)0.247500002;
                    SaveManager.GetInstance().SavePositionZ = (float)-0.599544048;
                    break;
                case 4:
                    SaveManager.GetInstance().SavePositionX = (float)1.41192055;
                    SaveManager.GetInstance().SavePositionY = (float)0.247500002;
                    SaveManager.GetInstance().SavePositionZ = (float)5.60981464;
                    break;
                case 5:
                    SaveManager.GetInstance().SavePositionX = (float)-15.7427101;
                    SaveManager.GetInstance().SavePositionY = (float)0.247500002;
                    SaveManager.GetInstance().SavePositionZ = (float)6.62174702;
                    break;
                default:
                break;
            }
        }
        else if(nani == "Foretina"){
            switch(enemyAssignedID){
                case 1:
                    SaveManager.GetInstance().SavePositionX = (float)0.943630219;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)4.20855999;
                    break;
                case 2:
                    SaveManager.GetInstance().SavePositionX = (float)6.17705917;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)1.71969223;
                    break;
                case 3:
                    SaveManager.GetInstance().SavePositionX = (float)-1.15647697;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)-3.5889082;
                    break;
                case 4:
                    SaveManager.GetInstance().SavePositionX = (float)14.7683144;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)1.39684868;
                    break;
                case 5:
                    SaveManager.GetInstance().SavePositionX = (float)16.3858719;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)-3.03118515;
                    break;
                default:
                break;
            }
        }
        else if(nani == "Probocean"){
            switch(enemyAssignedID){
                case 1:
                    SaveManager.GetInstance().SavePositionX = (float)-16.1454144;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)4.20636702;
                    break;
                case 2:
                    SaveManager.GetInstance().SavePositionX = (float)-12.1263657;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)7.48598337;
                    break;
                case 3:
                    SaveManager.GetInstance().SavePositionX = (float)-2.66701841;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)-1.57765388;
                    break;
                case 4:
                    SaveManager.GetInstance().SavePositionX = (float)2.57497644;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)0.0604065657;
                    break;
                case 5:
                    SaveManager.GetInstance().SavePositionX = (float)7.50845146;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)-2.23319674;
                    break;
                case 6:
                    SaveManager.GetInstance().SavePositionX = (float)12.3925638;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)6.46293831;
                    break;
                case 7:
                    SaveManager.GetInstance().SavePositionX = (float)16.9207153;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)3.40372467;
                    break;
                case 8:
                    SaveManager.GetInstance().SavePositionX = (float)-11.1017723;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)0.590304852;
                    break;
                default:
                break;
            }
        }
        else if(nani == "Cavectar"){
            switch(enemyAssignedID){
                case 1:
                    SaveManager.GetInstance().SavePositionX = (float)12.8358412;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)-5.0005908;
                    break;
                case 2:
                    SaveManager.GetInstance().SavePositionX = (float)3.98535085;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)0.46959281;
                    break;
                case 3:
                    SaveManager.GetInstance().SavePositionX = (float)0.683839321;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)-4.65317392;
                    break;
                case 4:
                    SaveManager.GetInstance().SavePositionX = (float)-2.08590555;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)4.78822184;
                    break;
                case 5:
                    SaveManager.GetInstance().SavePositionX = (float)-8.76816845;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)-1.21441627;
                    break;
                case 6:
                    SaveManager.GetInstance().SavePositionX = (float)-2.66020346;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)0.435508132;
                    break;
                case 7:
                    SaveManager.GetInstance().SavePositionX = (float)-14.4152393;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)-1.27182269;
                    break;
                case 8:
                    SaveManager.GetInstance().SavePositionX = (float)15.366396;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)-1.31020379;
                    break;
                default:
                break;
            }
        }
        else if(nani == "Magmatos"){
            switch(enemyAssignedID){
                case 1:
                    SaveManager.GetInstance().SavePositionX = (float)10.2076607;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)-4.413095;
                    break;
                case 2:
                    SaveManager.GetInstance().SavePositionX = (float)0.761656284;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)4.41648388;
                    break;
                case 3:
                    SaveManager.GetInstance().SavePositionX = (float)-14.5963097;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)-0.110899806;
                    break;
                case 4:
                    SaveManager.GetInstance().SavePositionX = (float)-5.45205545;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)6.70268917;
                    break;
                case 5:
                    SaveManager.GetInstance().SavePositionX = (float)9.23766613;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)5.9569664;
                    break;
                case 6:
                    SaveManager.GetInstance().SavePositionX = (float)-2.56495619;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)-2.30990148;
                    break;
                case 7:
                    SaveManager.GetInstance().SavePositionX = (float)-14.4152393;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)3.35146427;
                    break;
                case 8:
                    SaveManager.GetInstance().SavePositionX = (float)16.4213104;
                    SaveManager.GetInstance().SavePositionY = (float)0.330000013;
                    SaveManager.GetInstance().SavePositionZ = (float)-4.73748493;
                    break;
                default:
                break;
            }
        }
    }
}
