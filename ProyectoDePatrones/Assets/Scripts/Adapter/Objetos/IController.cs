using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IController
{
    float GetHorizontalInput();
    bool IsJumpButtonDown();
    bool IsJumpButtonUp();
}
