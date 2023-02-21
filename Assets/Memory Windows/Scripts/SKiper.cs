using System.Collections;
using System.Collections.Generic;
using Jackal;
using UnityEngine;

public class SKiper : Singleton<SKiper>
{
    [SerializeField] private Window[] _windows;
    [SerializeField] private List<Window> _checkWindows;

    void OnValidate()
    {
        _windows = GetComponentsInChildren<Window>();

        _checkWindows = new List<Window>();

        for (int i = 0; i < _windows.Length; i++)
        {
            _checkWindows.Add(_windows[i]);
        }
    }

    public void Skip()
    {
        Debug.Log("Check");

        for (int i = 1; i < _checkWindows.Count; i++)
        {
            if (_checkWindows[0].CheckWindow(_checkWindows[i]))
            {
                _checkWindows[0].Show();
                _checkWindows[i].Show();
                _checkWindows.Remove(_checkWindows[0]);
                _checkWindows.Remove(_checkWindows[i-1]);

                return;
            }
        }
    }
}