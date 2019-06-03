using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TradeButtonManager : MonoBehaviour
{

    public void exitButtonListen()
    {
        SceneManager.LoadScene("area01", LoadSceneMode.Single);
    }


}
