using TMPro;
using UnityEngine;

public class TextUpdater : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] textsToDisplay;
    public float updateInterval = 3f; // Intervalo de tempo em segundos entre as trocas de texto
    private int currentIndex = 0;
    private bool stopUpdating = false;

    void Start()
    {
        // Inicie o processo de atualiza��o do texto
        InvokeRepeating("UpdateText", 0f, updateInterval);
    }

    void UpdateText()
    {
        // Verifica se h� texto suficiente para exibir
        if (textsToDisplay.Length == 0)
        {
            Debug.LogWarning("Nenhum texto para exibir!");
            return;
        }

        // Atualize o texto e v� para o pr�ximo
        textComponent.text = textsToDisplay[currentIndex];
        currentIndex++;

        // Verifique se atingiu o �ltimo texto
        if (currentIndex >= textsToDisplay.Length)
        {
            // Pare de invocar a fun��o UpdateText
            stopUpdating = true;
            CancelInvoke("UpdateText");
        }
    }

    // Fun��o para iniciar a troca de texto manualmente
    public void StartTextUpdate()
    {
        if (!stopUpdating)
        {
            InvokeRepeating("UpdateText", 0f, updateInterval);
        }
    }
}