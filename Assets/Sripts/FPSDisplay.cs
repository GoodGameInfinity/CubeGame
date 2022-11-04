using UnityEngine;
using TMPro;

[RequireComponent(typeof(FPSCounter))]
public class FPSDisplay : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _label;
    private FPSCounter _fpsCounter;

    private void Start()
    {
        _fpsCounter = GetComponent<FPSCounter>();
    }

    private void Update()
    {
        //_label.text = Mathf.Clamp(_fpsCounter.FPS, 0, 99).ToString();
        _label.text = _fpsCounter.FPS.ToString();
    }
}
