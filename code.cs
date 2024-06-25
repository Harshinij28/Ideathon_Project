// GOBACK BUTTON
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class Goback : MonoBehaviour
{
  public string previousScene2;
    public void LoadPreviousPage(){
        SceneManager.LoadScene(previousScene2);
    }
}
//----------------------------------------------------------------------

using UnityEngine;
using UnityEngine.SceneManagement;
public class pageRedirect : MonoBehaviour
{
   public string scenename;
   public void LoadPage(){
SceneManager.LoadScene(scenename);
   }
}
//---------------------------------STATE BUTTON--------------------------
using UnityEngine;
using UnityEngine.SceneManagement;
   
public class redirect : MonoBehaviour
{
   public string sceneName1;
   public string sceneName2;
   public string sceneName3;
   public string sceneName4;
  public void LoadTamilNadu(){
    SceneManager.LoadScene(sceneName1);
  }   
  public void LoadKerala(){
     SceneManager.LoadScene(sceneName2);
  }
  public void LoadKarnataka(){
     SceneManager.LoadScene(sceneName3);
  }
  public void LoadGoa(){
     SceneManager.LoadScene(sceneName4);
  }
}
