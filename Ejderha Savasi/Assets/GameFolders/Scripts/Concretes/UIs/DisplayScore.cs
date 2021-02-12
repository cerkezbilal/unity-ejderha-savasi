using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


namespace EjderhaSavasi.Uis
{
    public class DisplayScore : MonoBehaviour
    {
        TextMeshProUGUI _scoreText;
        private void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();

        }

        
        //Eventi uyandıran çağıran fonskiyon
        private void Start()
        {
            GameManager.Instance.OnScoreChanged += HandleOnScoreChanged;
            HandleOnScoreChanged();
        }

        //Game Manager şişmesin boşalsın diye her oyun kapandığında gitsin diye

        private void OnDisable()
        {
            GameManager.Instance.OnScoreChanged -= HandleOnScoreChanged;
        }

        //score yazan ve event i uyandıracak fonksiyon
        private void HandleOnScoreChanged(int score = 0)
        {
            _scoreText.text = $"Score:{score}";
        }
    }
}

