﻿#pragma checksum "E:\scholl\ky3_c#\lab5\lab5\bai3.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4BA3F64D7147B76B1AFA57D8D5A6A32B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab5
{
    partial class bai3 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(global::Windows.UI.Xaml.Controls.Primitives.RangeBase obj, global::System.Double value)
            {
                obj.Value = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class bai3_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            Ibai3_Bindings
        {
            private global::lab5.bai3 dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ProgressBar obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj5ValueDisabled = false;

            private bai3_obj1_BindingsTracking bindingsTracking;

            public bai3_obj1_Bindings()
            {
                this.bindingsTracking = new bai3_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 124 && columnNumber == 22)
                {
                    isobj5ValueDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // bai3.xaml line 117
                        this.obj5 = (global::Windows.UI.Xaml.Controls.ProgressBar)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // Ibai3_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::lab5.bai3)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::lab5.bai3 obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MySlider(obj.MySlider, phase);
                    }
                }
            }
            private void Update_MySlider(global::Windows.UI.Xaml.Controls.ProgressBar obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_MySlider(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MySlider_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_MySlider_Value(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // bai3.xaml line 117
                    if (!isobj5ValueDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(this.obj5, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class bai3_obj1_BindingsTracking
            {
                private global::System.WeakReference<bai3_obj1_Bindings> weakRefToBindingObj; 

                public bai3_obj1_BindingsTracking(bai3_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<bai3_obj1_Bindings>(obj);
                }

                public bai3_obj1_Bindings TryGetBindingObject()
                {
                    bai3_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_MySlider(null);
                }

                public void DependencyPropertyChanged_MySlider_Value(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    bai3_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Windows.UI.Xaml.Controls.ProgressBar obj = sender as global::Windows.UI.Xaml.Controls.ProgressBar;
                        if (obj != null)
                        {
                            bindings.Update_MySlider_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                private global::Windows.UI.Xaml.Controls.ProgressBar cache_MySlider = null;
                private long tokenDPC_MySlider_Value = 0;
                public void UpdateChildListeners_MySlider(global::Windows.UI.Xaml.Controls.ProgressBar obj)
                {
                    if (obj != cache_MySlider)
                    {
                        if (cache_MySlider != null)
                        {
                            cache_MySlider.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, tokenDPC_MySlider_Value);
                            cache_MySlider = null;
                        }
                        if (obj != null)
                        {
                            cache_MySlider = obj;
                            tokenDPC_MySlider_Value = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, DependencyPropertyChanged_MySlider_Value);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // bai3.xaml line 53
                {
                    this.MyflyouButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 3: // bai3.xaml line 96
                {
                    this.MyAutoSuggesBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.MyAutoSuggesBox).TextChanged += this.MyAutoSuggesBox_TextChanged;
                }
                break;
            case 4: // bai3.xaml line 107
                {
                    this.MySlider = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 5: // bai3.xaml line 117
                {
                    this.MyProgressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 6: // bai3.xaml line 128
                {
                    this.MyProgressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 7: // bai3.xaml line 59
                {
                    this.Myflyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 8: // bai3.xaml line 63
                {
                    this.InnerFlyouButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.InnerFlyouButton).Click += this.InnerFlyouButton_Click;
                }
                break;
            case 9: // bai3.xaml line 45
                {
                    this.MyCalerdarView = (global::Windows.UI.Xaml.Controls.CalendarView)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarView)this.MyCalerdarView).SelectedDatesChanged += this.MyCalerdarView_SelectedDatesChanged;
                }
                break;
            case 10: // bai3.xaml line 49
                {
                    this.ClendarViewResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // bai3.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    bai3_obj1_Bindings bindings = new bai3_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

