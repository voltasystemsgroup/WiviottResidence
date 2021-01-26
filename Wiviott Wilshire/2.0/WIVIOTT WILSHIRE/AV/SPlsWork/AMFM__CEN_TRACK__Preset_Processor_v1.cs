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

namespace CrestronModule_AMFM__CEN_TRACK__PRESET_PROCESSOR_V1
{
    public class CrestronModuleClass_AMFM__CEN_TRACK__PRESET_PROCESSOR_V1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput AMACTIVE;
        Crestron.Logos.SplusObjects.DigitalInput FMACTIVE;
        Crestron.Logos.SplusObjects.DigitalInput FMIACTIVE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> AMPRESETIN;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> FMPRESETIN;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> PRESETOUT__DOLLAR__;
        private void PROCESSAMPRESET (  SplusExecutionContext __context__, ushort INDEX ) 
            { 
            
            __context__.SourceCodeLine = 73;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AMPRESETIN[ INDEX ] .UshortValue == 0))  ) ) 
                {
                __context__.SourceCodeLine = 74;
                MakeString ( PRESETOUT__DOLLAR__ [ INDEX] , "{0:d}. Preset {1:d}", (short)INDEX, (short)INDEX) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 76;
                MakeString ( PRESETOUT__DOLLAR__ [ INDEX] , "{0:d}. {1:d}", (short)INDEX, (short)AMPRESETIN[ INDEX ] .UshortValue) ; 
                }
            
            
            }
            
        private void PROCESSFMPRESET (  SplusExecutionContext __context__, ushort INDEX ) 
            { 
            ushort TEMP = 0;
            
            
            __context__.SourceCodeLine = 83;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FMPRESETIN[ INDEX ] .UshortValue == 0))  ) ) 
                {
                __context__.SourceCodeLine = 84;
                MakeString ( PRESETOUT__DOLLAR__ [ INDEX] , "{0:d}. Preset {1:d}", (short)INDEX, (short)INDEX) ; 
                }
            
            else 
                { 
                __context__.SourceCodeLine = 87;
                TEMP = (ushort) ( (FMPRESETIN[ INDEX ] .UshortValue / 10) ) ; 
                __context__.SourceCodeLine = 88;
                MakeString ( PRESETOUT__DOLLAR__ [ INDEX] , "{0:d}. {1:d}.{2:d}", (short)INDEX, (short)(TEMP / 10), (short)Mod( TEMP , 10 )) ; 
                } 
            
            
            }
            
        private void PROCESSFMIPRESET (  SplusExecutionContext __context__, ushort INDEX ) 
            { 
            
            __context__.SourceCodeLine = 94;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FMPRESETIN[ INDEX ] .UshortValue == 0))  ) ) 
                {
                __context__.SourceCodeLine = 95;
                MakeString ( PRESETOUT__DOLLAR__ [ INDEX] , "{0:d}. Preset {1:d}", (short)INDEX, (short)INDEX) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 97;
                MakeString ( PRESETOUT__DOLLAR__ [ INDEX] , "{0:d}. {1:d}.{2:d2}", (short)INDEX, (short)(FMPRESETIN[ INDEX ] .UshortValue / 100), (short)Mod( FMPRESETIN[ INDEX ] .UshortValue , 100 )) ; 
                }
            
            
            }
            
        object AMPRESETIN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort INDEX = 0;
                
                
                __context__.SourceCodeLine = 104;
                INDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 105;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AMACTIVE  .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 106;
                    PROCESSAMPRESET (  __context__ , (ushort)( INDEX )) ; 
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object FMPRESETIN_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort INDEX = 0;
            
            
            __context__.SourceCodeLine = 113;
            INDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 114;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FMACTIVE  .Value == 1))  ) ) 
                {
                __context__.SourceCodeLine = 115;
                PROCESSFMPRESET (  __context__ , (ushort)( INDEX )) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 116;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FMIACTIVE  .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 117;
                    PROCESSFMIPRESET (  __context__ , (ushort)( INDEX )) ; 
                    }
                
                }
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object AMACTIVE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 124;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)20; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            {
            __context__.SourceCodeLine = 125;
            PROCESSAMPRESET (  __context__ , (ushort)( I )) ; 
            __context__.SourceCodeLine = 124;
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FMACTIVE_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 132;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)20; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            {
            __context__.SourceCodeLine = 133;
            PROCESSFMPRESET (  __context__ , (ushort)( I )) ; 
            __context__.SourceCodeLine = 132;
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FMIACTIVE_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 140;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)20; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            {
            __context__.SourceCodeLine = 141;
            PROCESSFMIPRESET (  __context__ , (ushort)( I )) ; 
            __context__.SourceCodeLine = 140;
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
        
        __context__.SourceCodeLine = 146;
        WaitForInitializationComplete ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    AMACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( AMACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( AMACTIVE__DigitalInput__, AMACTIVE );
    
    FMACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( FMACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( FMACTIVE__DigitalInput__, FMACTIVE );
    
    FMIACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( FMIACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( FMIACTIVE__DigitalInput__, FMIACTIVE );
    
    AMPRESETIN = new InOutArray<AnalogInput>( 20, this );
    for( uint i = 0; i < 20; i++ )
    {
        AMPRESETIN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( AMPRESETIN__AnalogSerialInput__ + i, AMPRESETIN__AnalogSerialInput__, this );
        m_AnalogInputList.Add( AMPRESETIN__AnalogSerialInput__ + i, AMPRESETIN[i+1] );
    }
    
    FMPRESETIN = new InOutArray<AnalogInput>( 20, this );
    for( uint i = 0; i < 20; i++ )
    {
        FMPRESETIN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( FMPRESETIN__AnalogSerialInput__ + i, FMPRESETIN__AnalogSerialInput__, this );
        m_AnalogInputList.Add( FMPRESETIN__AnalogSerialInput__ + i, FMPRESETIN[i+1] );
    }
    
    PRESETOUT__DOLLAR__ = new InOutArray<StringOutput>( 20, this );
    for( uint i = 0; i < 20; i++ )
    {
        PRESETOUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( PRESETOUT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( PRESETOUT__DOLLAR____AnalogSerialOutput__ + i, PRESETOUT__DOLLAR__[i+1] );
    }
    
    
    for( uint i = 0; i < 20; i++ )
        AMPRESETIN[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( AMPRESETIN_OnChange_0, false ) );
        
    for( uint i = 0; i < 20; i++ )
        FMPRESETIN[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( FMPRESETIN_OnChange_1, false ) );
        
    AMACTIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( AMACTIVE_OnPush_2, false ) );
    FMACTIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( FMACTIVE_OnPush_3, false ) );
    FMIACTIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( FMIACTIVE_OnPush_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_AMFM__CEN_TRACK__PRESET_PROCESSOR_V1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint AMACTIVE__DigitalInput__ = 0;
const uint FMACTIVE__DigitalInput__ = 1;
const uint FMIACTIVE__DigitalInput__ = 2;
const uint AMPRESETIN__AnalogSerialInput__ = 0;
const uint FMPRESETIN__AnalogSerialInput__ = 20;
const uint PRESETOUT__DOLLAR____AnalogSerialOutput__ = 0;

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
