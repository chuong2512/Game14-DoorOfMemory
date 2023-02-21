using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipButton : MonoBehaviour
{
    public void OnMouseDown()
    {
        SKiper.Instance.Skip();
        GameDataManager.Instance.playerData.SubDiamond(1);
    }
}