using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;
using UnityEngine.SceneManagement;


public class VoiceCommandProcessor : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private string[] keywords = { "reset" };

    void Start()
    {
        keywordRecognizer = new KeywordRecognizer(keywords);
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizerOnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void KeywordRecognizerOnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        if (args.text == "reset")
        {
            ResetScene();
        }
    }

    private void ResetScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }


    void OnDestroy()
    {
        if (keywordRecognizer != null)
        {
            keywordRecognizer.Stop();
            keywordRecognizer.Dispose();
        }
    }
}
