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

        }
        else if(nani == "Cavectar"){

        }
        else if(nani == "Magmatos"){

        }
    }
}
