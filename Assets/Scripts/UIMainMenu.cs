using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] TMP_Dropdown _dropChapter;
    [SerializeField] Button _manualFirstSceneButton;
    [SerializeField] Button _exitButton;

    // Start is called before the first frame update
    void Start()
    {
        _manualFirstSceneButton.onClick.AddListener(StartFirstScene);
        _exitButton.onClick.AddListener(ExitApp);
    }

    public void dropChanged() {
        switch(_dropChapter.value){
            case 1:
                ScenesManager.Instance.LoadScene(ScenesManager.Scene.Hunt01);
                break;
            case 2: 
                ScenesManager.Instance.LoadScene(ScenesManager.Scene.Hunt02);
                break;
            case 3:
                ScenesManager.Instance.LoadScene(ScenesManager.Scene.Hunt03);
                break;
            case 4:
                ScenesManager.Instance.LoadScene(ScenesManager.Scene.Hunt04);
                break;
            case 5:
                ScenesManager.Instance.LoadScene(ScenesManager.Scene.Hunt05);
                break;
            case 6:
                ScenesManager.Instance.LoadScene(ScenesManager.Scene.Hunt06);
                break;
            case 7:
                ScenesManager.Instance.LoadScene(ScenesManager.Scene.Hunt07);
                break;
            case 8:
                ScenesManager.Instance.LoadScene(ScenesManager.Scene.Hunt08);
                break;
            case 9:
                ScenesManager.Instance.LoadScene(ScenesManager.Scene.Hunt09);
                break;
            case 10:
                ScenesManager.Instance.LoadScene(ScenesManager.Scene.Hunt10);
                break;
            case 11:
                ScenesManager.Instance.LoadScene(ScenesManager.Scene.Hunt11);
                break;
            case 12:
                ScenesManager.Instance.LoadScene(ScenesManager.Scene.Hunt12);
                break;

        }
    }

    private void StartFirstScene()
    {
        ScenesManager.Instance.LoadNextScene();
    }

    private void ExitApp()
    {
        Application.Quit();
    }
}
