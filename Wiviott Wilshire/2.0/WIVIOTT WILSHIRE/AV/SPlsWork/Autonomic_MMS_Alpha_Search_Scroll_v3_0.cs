using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_AUTONOMIC_MMS_ALPHA_SEARCH_SCROLL_V3_0
{
    public class UserModuleClass_AUTONOMIC_MMS_ALPHA_SEARCH_SCROLL_V3_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput SCROLL_UP;
        Crestron.Logos.SplusObjects.DigitalInput SCROLL_DOWN;
        Crestron.Logos.SplusObjects.AnalogInput ALPHA_SCROLL_VAL;
        Crestron.Logos.SplusObjects.AnalogInput ALPHA_SCROLL_START;
        Crestron.Logos.SplusObjects.AnalogInput WAIT_TIME;
        Crestron.Logos.SplusObjects.DigitalOutput SHOWALPHA;
        Crestron.Logos.SplusObjects.AnalogOutput ALPHA_SCALED;
        Crestron.Logos.SplusObjects.StringOutput ALPHA_COMMAND__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput ALPHADISPLAY__DOLLAR__;
        ushort GIALPHAVAL = 0;
        ushort GISCROLLING = 0;
        ushort GISCROLLBYCLICK = 0;
        private void SENDKB (  SplusExecutionContext __context__, ushort CHAR ) 
            { 
            
            __context__.SourceCodeLine = 45;
            ALPHA_COMMAND__DOLLAR__  .UpdateValue ( "KB " + Functions.Chr (  (int) ( CHAR ) )  ) ; 
            
            }
            
        private void SCROLLCHECK (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 53;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GISCROLLING == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 56;
                SHOWALPHA  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 59;
                GISCROLLING = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 60;
                CreateWait ( "SCROLL" , WAIT_TIME  .UshortValue , SCROLL_Callback ) ;
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 78;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GISCROLLBYCLICK == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 79;
                    RetimeWait ( (int)(WAIT_TIME  .UshortValue + 100), "SCROLL" ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 81;
                    RetimeWait ( (int)WAIT_TIME  .UshortValue, "SCROLL" ) ; 
                    }
                
                } 
            
            
            }
            
        public void SCROLL_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 63;
            SHOWALPHA  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 65;
            GISCROLLING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 67;
            SENDKB (  __context__ , (ushort)( GIALPHAVAL )) ; 
            __context__.SourceCodeLine = 69;
            Functions.Delay (  (int) ( 100 ) ) ; 
            __context__.SourceCodeLine = 72;
            Functions.ProcessLogic ( ) ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    object SCROLL_UP_OnPush_0 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 89;
            GISCROLLBYCLICK = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 91;
            GIALPHAVAL = (ushort) ( (GIALPHAVAL - 1) ) ; 
            __context__.SourceCodeLine = 96;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GIALPHAVAL < 64 ))  ) ) 
                {
                __context__.SourceCodeLine = 96;
                GIALPHAVAL = (ushort) ( 64 ) ; 
                }
            
            __context__.SourceCodeLine = 99;
            SCROLLCHECK (  __context__  ) ; 
            __context__.SourceCodeLine = 102;
            ALPHADISPLAY__DOLLAR__  .UpdateValue ( Functions.Chr (  (int) ( GIALPHAVAL ) )  ) ; 
            __context__.SourceCodeLine = 103;
            ALPHA_SCALED  .Value = (ushort) ( GIALPHAVAL ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SCROLL_DOWN_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 116;
        GISCROLLBYCLICK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 118;
        GIALPHAVAL = (ushort) ( (GIALPHAVAL + 1) ) ; 
        __context__.SourceCodeLine = 123;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GIALPHAVAL > 90 ))  ) ) 
            {
            __context__.SourceCodeLine = 123;
            GIALPHAVAL = (ushort) ( 90 ) ; 
            }
        
        __context__.SourceCodeLine = 126;
        SCROLLCHECK (  __context__  ) ; 
        __context__.SourceCodeLine = 129;
        ALPHADISPLAY__DOLLAR__  .UpdateValue ( Functions.Chr (  (int) ( GIALPHAVAL ) )  ) ; 
        __context__.SourceCodeLine = 130;
        ALPHA_SCALED  .Value = (ushort) ( GIALPHAVAL ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ALPHA_SCROLL_VAL_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort VAL = 0;
        
        
        __context__.SourceCodeLine = 143;
        GISCROLLBYCLICK = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 145;
        VAL = (ushort) ( ((((65535 - ALPHA_SCROLL_VAL  .UshortValue) * 27) / 65535) + 64) ) ; 
        __context__.SourceCodeLine = 147;
        GIALPHAVAL = (ushort) ( VAL ) ; 
        __context__.SourceCodeLine = 153;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GIALPHAVAL < 64 ))  ) ) 
            {
            __context__.SourceCodeLine = 154;
            GIALPHAVAL = (ushort) ( 64 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 156;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GIALPHAVAL > 90 ))  ) ) 
                {
                __context__.SourceCodeLine = 157;
                GIALPHAVAL = (ushort) ( 90 ) ; 
                }
            
            }
        
        __context__.SourceCodeLine = 159;
        SCROLLCHECK (  __context__  ) ; 
        __context__.SourceCodeLine = 161;
        ALPHADISPLAY__DOLLAR__  .UpdateValue ( Functions.Chr (  (int) ( GIALPHAVAL ) )  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ALPHA_SCROLL_START_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 168;
        GIALPHAVAL = (ushort) ( ALPHA_SCROLL_START  .UshortValue ) ; 
        __context__.SourceCodeLine = 170;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GIALPHAVAL < 64 ))  ) ) 
            {
            __context__.SourceCodeLine = 171;
            GIALPHAVAL = (ushort) ( 64 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 172;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GIALPHAVAL > 90 ))  ) ) 
                {
                __context__.SourceCodeLine = 173;
                GIALPHAVAL = (ushort) ( 90 ) ; 
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 184;
        GIALPHAVAL = (ushort) ( 64 ) ; 
        __context__.SourceCodeLine = 186;
        GISCROLLING = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    SCROLL_UP = new Crestron.Logos.SplusObjects.DigitalInput( SCROLL_UP__DigitalInput__, this );
    m_DigitalInputList.Add( SCROLL_UP__DigitalInput__, SCROLL_UP );
    
    SCROLL_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( SCROLL_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( SCROLL_DOWN__DigitalInput__, SCROLL_DOWN );
    
    SHOWALPHA = new Crestron.Logos.SplusObjects.DigitalOutput( SHOWALPHA__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOWALPHA__DigitalOutput__, SHOWALPHA );
    
    ALPHA_SCROLL_VAL = new Crestron.Logos.SplusObjects.AnalogInput( ALPHA_SCROLL_VAL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ALPHA_SCROLL_VAL__AnalogSerialInput__, ALPHA_SCROLL_VAL );
    
    ALPHA_SCROLL_START = new Crestron.Logos.SplusObjects.AnalogInput( ALPHA_SCROLL_START__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ALPHA_SCROLL_START__AnalogSerialInput__, ALPHA_SCROLL_START );
    
    WAIT_TIME = new Crestron.Logos.SplusObjects.AnalogInput( WAIT_TIME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( WAIT_TIME__AnalogSerialInput__, WAIT_TIME );
    
    ALPHA_SCALED = new Crestron.Logos.SplusObjects.AnalogOutput( ALPHA_SCALED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ALPHA_SCALED__AnalogSerialOutput__, ALPHA_SCALED );
    
    ALPHA_COMMAND__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ALPHA_COMMAND__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ALPHA_COMMAND__DOLLAR____AnalogSerialOutput__, ALPHA_COMMAND__DOLLAR__ );
    
    ALPHADISPLAY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ALPHADISPLAY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ALPHADISPLAY__DOLLAR____AnalogSerialOutput__, ALPHADISPLAY__DOLLAR__ );
    
    SCROLL_Callback = new WaitFunction( SCROLL_CallbackFn );
    
    SCROLL_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLL_UP_OnPush_0, false ) );
    SCROLL_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCROLL_DOWN_OnPush_1, false ) );
    ALPHA_SCROLL_VAL.OnAnalogChange.Add( new InputChangeHandlerWrapper( ALPHA_SCROLL_VAL_OnChange_2, false ) );
    ALPHA_SCROLL_START.OnAnalogChange.Add( new InputChangeHandlerWrapper( ALPHA_SCROLL_START_OnChange_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_AUTONOMIC_MMS_ALPHA_SEARCH_SCROLL_V3_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction SCROLL_Callback;


const uint SCROLL_UP__DigitalInput__ = 0;
const uint SCROLL_DOWN__DigitalInput__ = 1;
const uint ALPHA_SCROLL_VAL__AnalogSerialInput__ = 0;
const uint ALPHA_SCROLL_START__AnalogSerialInput__ = 1;
const uint WAIT_TIME__AnalogSerialInput__ = 2;
const uint SHOWALPHA__DigitalOutput__ = 0;
const uint ALPHA_SCALED__AnalogSerialOutput__ = 0;
const uint ALPHA_COMMAND__DOLLAR____AnalogSerialOutput__ = 1;
const uint ALPHADISPLAY__DOLLAR____AnalogSerialOutput__ = 2;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
