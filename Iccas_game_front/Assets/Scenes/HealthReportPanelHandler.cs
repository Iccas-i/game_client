using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;

[Serializable]
public class HealthReport
{
    public string response;
    public string score;
    public string time;
}


public class HealthReportPanelHandler : MonoBehaviour
{
    public Button openReportButton;
    public GameObject reportPanel;
    public TMP_Text healthInfoText;
    public TMP_Text scoreText;
    public TMP_Text TimeText;

    private string userId = "1234"; // 데모 임시 아이디
    private string serverURL = "http://192.168.0.95:3000/ask/report";


    
    void Start()
    {
        openReportButton.onClick.AddListener(OpenHealthReport);
    }

    public void OpenHealthReport()
    {
        reportPanel.SetActive(true);
        StartCoroutine(GetHealthReport());
    }

    IEnumerator GetHealthReport()
    {
        using (UnityWebRequest www = UnityWebRequest.Get(serverURL + "?User_ID=" + userId)) // Get에선 Body.... 못써요 응애...
        {
            yield return www.SendWebRequest();

            Debug.Log("JSON 데이터: " + www.downloadHandler.text);
            if (www.result == UnityWebRequest.Result.Success)
            {
                string jsonResponse = www.downloadHandler.text;
                var healthReport = JsonUtility.FromJson<HealthReport>(jsonResponse);
                

                healthInfoText.text = healthReport.response;
                scoreText.text = healthReport.score;
                TimeText.text = healthReport.time;
            }
            else
            {
                healthInfoText.text = "데이터를 가져오지 못했습니다. 다시 시도해주세요.";
                scoreText.text = "";
                TimeText.text = "";
            }
        }
    }
}
