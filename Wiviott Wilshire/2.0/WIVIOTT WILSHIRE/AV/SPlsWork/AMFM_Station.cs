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

namespace CrestronModule_AMFM_STATION
{
    public class CrestronModuleClass_AMFM_STATION : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput AMACTIVE;
        Crestron.Logos.SplusObjects.DigitalInput FMACTIVE;
        Crestron.Logos.SplusObjects.AnalogInput AMFREQIN;
        Crestron.Logos.SplusObjects.AnalogInput FMFREQIN;
        Crestron.Logos.SplusObjects.AnalogInput AMPRESETIN;
        Crestron.Logos.SplusObjects.AnalogInput FMPRESETIN;
        Crestron.Logos.SplusObjects.StringOutput STATION__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PRESET__DOLLAR__;
        private void BUILDAM (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 58;
            MakeString ( STATION__DOLLAR__ , "{0:d} AM", (short)AMFREQIN  .UshortValue) ; 
            __context__.SourceCodeLine = 59;
            MakeString ( PRESET__DOLLAR__ , "{0:d} AM", (short)AMPRESETIN  .UshortValue) ; 
            
            }
            
        private void BUILDFM (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 64;
            MakeString ( STATION__DOLLAR__ , "{0:d}.{1:d2} FM", (short)(FMFREQIN  .UshortValue / 100), (short)Mod( FMFREQIN  .UshortValue , 100 )) ; 
            __context__.SourceCodeLine = 65;
            MakeString ( PRESET__DOLLAR__ , "{0:d}.{1:d2} FM", (short)(FMPRESETIN  .UshortValue / 100), (short)Mod( FMPRESETIN  .UshortValue , 100 )) ; 
            
            }
            
        object AMACTIVE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 70;
                BUILDAM (  __context__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object FMACTIVE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 75;
            BUILDFM (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object AMFREQIN_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 80;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AMACTIVE  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 81;
            BUILDAM (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AMPRESETIN_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 86;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AMACTIVE  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 87;
            BUILDAM (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FMPRESETIN_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 92;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FMACTIVE  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 93;
            BUILDFM (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FMFREQIN_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 98;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FMACTIVE  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 99;
            BUILDFM (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    AMACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( AMACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( AMACTIVE__DigitalInput__, AMACTIVE );
    
    FMACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( FMACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( FMACTIVE__DigitalInput__, FMACTIVE );
    
    AMFREQIN = new Crestron.Logos.SplusObjects.AnalogInput( AMFREQIN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AMFREQIN__AnalogSerialInput__, AMFREQIN );
    
    FMFREQIN = new Crestron.Logos.SplusObjects.AnalogInput( FMFREQIN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FMFREQIN__AnalogSerialInput__, FMFREQIN );
    
    AMPRESETIN = new Crestron.Logos.SplusObjects.AnalogInput( AMPRESETIN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AMPRESETIN__AnalogSerialInput__, AMPRESETIN );
    
    FMPRESETIN = new Crestron.Logos.SplusObjects.AnalogInput( FMPRESETIN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FMPRESETIN__AnalogSerialInput__, FMPRESETIN );
    
    STATION__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( STATION__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( STATION__DOLLAR____AnalogSerialOutput__, STATION__DOLLAR__ );
    
    PRESET__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PRESET__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( PRESET__DOLLAR____AnalogSerialOutput__, PRESET__DOLLAR__ );
    
    
    AMACTIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( AMACTIVE_OnPush_0, false ) );
    FMACTIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( FMACTIVE_OnPush_1, false ) );
    AMFREQIN.OnAnalogChange.Add( new InputChangeHandlerWrapper( AMFREQIN_OnChange_2, false ) );
    AMPRESETIN.OnAnalogChange.Add( new InputChangeHandlerWrapper( AMPRESETIN_OnChange_3, false ) );
    FMPRESETIN.OnAnalogChange.Add( new InputChangeHandlerWrapper( FMPRESETIN_OnChange_4, false ) );
    FMFREQIN.OnAnalogChange.Add( new InputChangeHandlerWrapper( FMFREQIN_OnChange_5, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_AMFM_STATION ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint AMACTIVE__DigitalInput__ = 0;
const uint FMACTIVE__DigitalInput__ = 1;
const uint AMFREQIN__AnalogSerialInput__ = 0;
const uint FMFREQIN__AnalogSerialInput__ = 1;
const uint AMPRESETIN__AnalogSerialInput__ = 2;
const uint FMPRESETIN__AnalogSerialInput__ = 3;
const uint STATION__DOLLAR____AnalogSerialOutput__ = 0;
const uint PRESET__DOLLAR____AnalogSerialOutput__ = 1;

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
