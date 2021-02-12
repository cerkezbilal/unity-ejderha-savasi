using EjderhaSavasi.Combat;
using EjderhaSavasi.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EjderhaSavasi.Controllers
{

    public class PlayerController : MonoBehaviour
    {
       
        bool _isLeftMouseClicked;
        Jump _jump;
        PcInputController _input;
        LaunchProjectile _launchProjectile;
        AudioSource _audioSource;
        Rigidbody2D _rigidbody2D;

        private void Awake()
        {
           _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _launchProjectile = GetComponent<LaunchProjectile>();
            _audioSource = GetComponent<AudioSource>();
            _input = new PcInputController();
        }


        private void Update()
        {
            //Bu kodu touch ile değiştir
            if (_input.LeftMouseClickDown)
            {
                _isLeftMouseClicked = true;
            }

            if (_input.RightMuseClickDown)
            {
                _launchProjectile.LaunchAction();
            }

        }

        private void FixedUpdate()
        {
            //Buraya yukarıdaki touch değişkenini yaz
            if (_isLeftMouseClicked)
            {
                _jump.JumpAction(_rigidbody2D);

                _audioSource.Play();
             
                _isLeftMouseClicked = false;
            }
        }

      


    }

}

