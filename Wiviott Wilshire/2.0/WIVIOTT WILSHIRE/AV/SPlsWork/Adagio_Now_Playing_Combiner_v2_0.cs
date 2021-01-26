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

namespace CrestronModule_ADAGIO_NOW_PLAYING_COMBINER_V2_0
{
    public class CrestronModuleClass_ADAGIO_NOW_PLAYING_COMBINER_V2_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput OFFLINE;
        Crestron.Logos.SplusObjects.StringInput LINE1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput LINE2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput TRANSPORT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NOWPLAYING__DOLLAR__;
        private void CREATE (  SplusExecutionContext __context__ ) 
            { 
            CrestronString TEMP__DOLLAR__;
            TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            
            __context__.SourceCodeLine = 44;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (OFFLINE  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 46;
                NOWPLAYING__DOLLAR__  .UpdateValue ( "\u001B\u0021Device not found\u001B\u0022on network\u001B\u0023\u0020"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 50;
                TEMP__DOLLAR__  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 51;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LINE1__DOLLAR__ == ""))  ) ) 
                    {
                    __context__.SourceCodeLine = 52;
                    TEMP__DOLLAR__  .UpdateValue ( TEMP__DOLLAR__ + "\u001B\u0021\u0020"  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 54;
                    TEMP__DOLLAR__  .UpdateValue ( TEMP__DOLLAR__ + "\u001B\u0021" + LINE1__DOLLAR__  ) ; 
                    }
                
                __context__.SourceCodeLine = 55;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LINE2__DOLLAR__ == ""))  ) ) 
                    {
                    __context__.SourceCodeLine = 56;
                    TEMP__DOLLAR__  .UpdateValue ( TEMP__DOLLAR__ + "\u001B\u0022\u0020"  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 58;
                    TEMP__DOLLAR__  .UpdateValue ( TEMP__DOLLAR__ + "\u001B\u0022" + LINE2__DOLLAR__  ) ; 
                    }
                
                __context__.SourceCodeLine = 59;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TRANSPORT__DOLLAR__ == ""))  ) ) 
                    {
                    __context__.SourceCodeLine = 60;
                    TEMP__DOLLAR__  .UpdateValue ( TEMP__DOLLAR__ + "\u001B\u0023\u0020"  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 62;
                    TEMP__DOLLAR__  .UpdateValue ( TEMP__DOLLAR__ + "\u001B\u0023" + TRANSPORT__DOLLAR__  ) ; 
                    }
                
                __context__.SourceCodeLine = 63;
                NOWPLAYING__DOLLAR__  .UpdateValue ( TEMP__DOLLAR__  ) ; 
                } 
            
            
            }
            
        object LINE1__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 69;
                CREATE (  __context__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object LINE2__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 74;
            CREATE (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object TRANSPORT__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 79;
        CREATE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OFFLINE_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 84;
        CREATE (  __context__  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 89;
        NOWPLAYING__DOLLAR__  .UpdateValue ( "\u001B\u0021 \u001B\u0022 \u001B\u0023 "  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    OFFLINE = new Crestron.Logos.SplusObjects.DigitalInput( OFFLINE__DigitalInput__, this );
    m_DigitalInputList.Add( OFFLINE__DigitalInput__, OFFLINE );
    
    LINE1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( LINE1__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( LINE1__DOLLAR____AnalogSerialInput__, LINE1__DOLLAR__ );
    
    LINE2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( LINE2__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( LINE2__DOLLAR____AnalogSerialInput__, LINE2__DOLLAR__ );
    
    TRANSPORT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( TRANSPORT__DOLLAR____AnalogSerialInput__, 1, this );
    m_StringInputList.Add( TRANSPORT__DOLLAR____AnalogSerialInput__, TRANSPORT__DOLLAR__ );
    
    NOWPLAYING__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYING__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOWPLAYING__DOLLAR____AnalogSerialOutput__, NOWPLAYING__DOLLAR__ );
    
    
    LINE1__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( LINE1__DOLLAR___OnChange_0, false ) );
    LINE2__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( LINE2__DOLLAR___OnChange_1, false ) );
    TRANSPORT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TRANSPORT__DOLLAR___OnChange_2, false ) );
    OFFLINE.OnDigitalChange.Add( new InputChangeHandlerWrapper( OFFLINE_OnChange_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_ADAGIO_NOW_PLAYING_COMBINER_V2_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint OFFLINE__DigitalInput__ = 0;
const uint LINE1__DOLLAR____AnalogSerialInput__ = 0;
const uint LINE2__DOLLAR____AnalogSerialInput__ = 1;
const uint TRANSPORT__DOLLAR____AnalogSerialInput__ = 2;
const uint NOWPLAYING__DOLLAR____AnalogSerialOutput__ = 0;

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
