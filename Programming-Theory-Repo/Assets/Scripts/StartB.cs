using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class StartB : MonoBehaviour
{
    public static StartB Instan;
    public int points;
    public GameObject inputNameText;
    public string playerName;
    public string playerNameNew;
    public Text textPlayername;
    public GameObject inputField;
    public Text startTXT;

    private void Awake()
    {
        if (Instan != null)
        {
            Destroy(gameObject);
            return;
        }
        Instan = this;
        DontDestroyOnLoad(gameObject);
        
        
        inputNameText.GetComponent<Text>().text = playerName;
        textPlayername.GetComponent<Text>().text = playerName;



    }

    [System.Serializable]
    class SaveData
    {
        public int points;
        public string playerName;
        public string playerNameNew;
    }

    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.points = points;
        data.playerName = playerName;
        data.playerNameNew = playerNameNew;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            points = data.points;
            playerName = data.playerName;
            data.playerNameNew = playerNameNew;
        }
    }
    
    public void StartNew()
    {
        playerNameNew = inputNameText.GetComponent<Text>().text;
        SaveScore();
        LoadScore();
        textPlayername.text = playerNameNew;

        if (inputField)
        {
            inputField.SetActive(false);
        }

        
        
        SceneManager.LoadScene(1);
        startTXT.text = "Restart";

    }
    

    public void Menu()
    {
        
        SceneManager.LoadScene(0);
        inputField.SetActive(true);
        startTXT.text = "Start";

    }
    public void Exit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }


}

