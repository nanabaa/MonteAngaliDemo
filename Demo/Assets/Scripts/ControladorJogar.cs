using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class ControladorJogar : MonoBehaviour
{
    private UIDocument document;
    private Button botao;

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        botao = document.rootVisualElement.Q<Button>("btnMapa");
        botao.RegisterCallback<ClickEvent>(onMapa);
        botao = document.rootVisualElement.Q<Button>("btnVoltar");
        botao.RegisterCallback<ClickEvent>(onVoltar);
    }

    void onMapa(ClickEvent evt)
    {
        SceneManager.LoadScene("Mapa");
    }

    void onVoltar(ClickEvent evt)
    {
        SceneManager.LoadScene("Menu");
    }
}