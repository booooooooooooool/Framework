using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindableProperty<T> where T : IEquatable<T>
{
    private T mValue = default(T);
    public T Value
    { 
        get 
        { 
            return mValue; 
        } 
        set
        {
            if (!mValue.Equals(value))
            {
                mValue = value;

                OnValueChanged?.Invoke(value);
            }
        }
    }
    public Action<T> OnValueChanged;
}
