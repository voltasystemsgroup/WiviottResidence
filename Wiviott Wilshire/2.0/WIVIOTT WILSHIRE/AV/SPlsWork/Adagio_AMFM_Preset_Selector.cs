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

namespace CrestronModule_ADAGIO_AMFM_PRESET_SELECTOR
{
    public class CrestronModuleClass_ADAGIO_AMFM_PRESET_SELECTOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput NEXT;
        Crestron.Logos.SplusObjects.DigitalInput PREV;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> PRESETIN;
        Crestron.Logos.SplusObjects.AnalogOutput FREQUENCY;
        ushort INDEX = 0;
        object NEXT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort COUNTER = 0;
                
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 52;
                COUNTER = (ushort) ( (INDEX + 1) ) ; 
                __context__.SourceCodeLine = 53;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( COUNTER > 20 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 54;
                    COUNTER = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 55;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)20; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 57;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PRESETIN[ COUNTER ] .UshortValue > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 59;
                        INDEX = (ushort) ( COUNTER ) ; 
                        __context__.SourceCodeLine = 60;
                        FREQUENCY  .Value = (ushort) ( PRESETIN[ COUNTER ] .UshortValue ) ; 
                        __context__.SourceCodeLine = 61;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 63;
                    COUNTER = (ushort) ( (COUNTER + 1) ) ; 
                    __context__.SourceCodeLine = 64;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( COUNTER > 20 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 65;
                        COUNTER = (ushort) ( 1 ) ; 
                        }
                    
                    __context__.SourceCodeLine = 55;
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object PREV_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort COUNTER = 0;
            
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 74;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INDEX > 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 75;
                COUNTER = (ushort) ( (INDEX - 1) ) ; 
                }
            
            __context__.SourceCodeLine = 76;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COUNTER == 0))  ) ) 
                {
                __context__.SourceCodeLine = 77;
                COUNTER = (ushort) ( 20 ) ; 
                }
            
            __context__.SourceCodeLine = 78;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)20; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 80;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PRESETIN[ COUNTER ] .UshortValue > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 82;
                    INDEX = (ushort) ( COUNTER ) ; 
                    __context__.SourceCodeLine = 83;
                    FREQUENCY  .Value = (ushort) ( PRESETIN[ COUNTER ] .UshortValue ) ; 
                    __context__.SourceCodeLine = 84;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 86;
                COUNTER = (ushort) ( (COUNTER - 1) ) ; 
                __context__.SourceCodeLine = 87;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COUNTER == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 88;
                    COUNTER = (ushort) ( 20 ) ; 
                    }
                
                __context__.SourceCodeLine = 78;
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
        
        __context__.SourceCodeLine = 94;
        INDEX = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    NEXT = new Crestron.Logos.SplusObjects.DigitalInput( NEXT__DigitalInput__, this );
    m_DigitalInputList.Add( NEXT__DigitalInput__, NEXT );
    
    PREV = new Crestron.Logos.SplusObjects.DigitalInput( PREV__DigitalInput__, this );
    m_DigitalInputList.Add( PREV__DigitalInput__, PREV );
    
    PRESETIN = new InOutArray<AnalogInput>( 20, this );
    for( uint i = 0; i < 20; i++ )
    {
        PRESETIN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( PRESETIN__AnalogSerialInput__ + i, PRESETIN__AnalogSerialInput__, this );
        m_AnalogInputList.Add( PRESETIN__AnalogSerialInput__ + i, PRESETIN[i+1] );
    }
    
    FREQUENCY = new Crestron.Logos.SplusObjects.AnalogOutput( FREQUENCY__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FREQUENCY__AnalogSerialOutput__, FREQUENCY );
    
    
    NEXT.OnDigitalPush.Add( new InputChangeHandlerWrapper( NEXT_OnPush_0, false ) );
    PREV.OnDigitalPush.Add( new InputChangeHandlerWrapper( PREV_OnPush_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_ADAGIO_AMFM_PRESET_SELECTOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint NEXT__DigitalInput__ = 0;
const uint PREV__DigitalInput__ = 1;
const uint PRESETIN__AnalogSerialInput__ = 0;
const uint FREQUENCY__AnalogSerialOutput__ = 0;

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
