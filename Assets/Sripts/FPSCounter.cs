using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    [SerializeField]
    private int _frameRange = 60;
    private int[] _fpsBuffer;
    private int _fpsBufferIndex;

    public int FPS { get; private set; }

    void Update()
    {
        if(_fpsBuffer == null || _frameRange != _fpsBuffer.Length)
        {
            InitializeBuffer();
        }
        UpdateBuffer();
        CalculateFPS();
    }

    private void InitializeBuffer()
    {
        if(_frameRange <= 0)
        {
            _frameRange = 1;
        }
        _fpsBuffer = new int[_frameRange];
        _fpsBufferIndex = 0;
    }

    private void UpdateBuffer()
    {
        _fpsBuffer[_fpsBufferIndex++] = (int)(1f / Time.unscaledDeltaTime);
        if(_fpsBufferIndex >= _frameRange)
        {
            _fpsBufferIndex = 0;
        }
    }

    private void CalculateFPS()
    {
        int sum = 0;
        for(int i = 0; i < _frameRange; i++)
        {
            sum += _fpsBuffer[i];
        }
        FPS = sum / _frameRange;


    }


}
