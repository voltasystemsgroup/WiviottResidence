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

namespace UserModule_AUTONOMIC_MMS_IP_PROCESSOR_V3_2_5
{
    public class UserModuleClass_AUTONOMIC_MMS_IP_PROCESSOR_V3_2_5 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput PREVPAGE;
        Crestron.Logos.SplusObjects.DigitalInput NEXTPAGE;
        Crestron.Logos.SplusObjects.DigitalInput HOME;
        Crestron.Logos.SplusObjects.DigitalInput END;
        Crestron.Logos.SplusObjects.DigitalInput CONNECT;
        Crestron.Logos.SplusObjects.DigitalInput EVENTS_ENABLED;
        Crestron.Logos.SplusObjects.DigitalInput GO_BACK;
        Crestron.Logos.SplusObjects.DigitalInput LIST_ADDTOQUEUE;
        Crestron.Logos.SplusObjects.DigitalInput LIST_PLAYNOW;
        Crestron.Logos.SplusObjects.DigitalInput THUMBSUP;
        Crestron.Logos.SplusObjects.DigitalInput THUMBSDOWN;
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput SETOSD;
        Crestron.Logos.SplusObjects.DigitalInput CONTEXTBUTTON1;
        Crestron.Logos.SplusObjects.DigitalInput CONTEXTBUTTON2;
        Crestron.Logos.SplusObjects.DigitalInput CONTEXTBUTTON3;
        Crestron.Logos.SplusObjects.DigitalInput CONTEXTBUTTON4;
        Crestron.Logos.SplusObjects.DigitalInput ACTIONS;
        Crestron.Logos.SplusObjects.DigitalInput SAVEPLAYLIST;
        Crestron.Logos.SplusObjects.DigitalInput SEARCH;
        Crestron.Logos.SplusObjects.DigitalInput CLEARQUEUE;
        Crestron.Logos.SplusObjects.DigitalInput ZONES;
        Crestron.Logos.SplusObjects.DigitalInput SEEK_BACK;
        Crestron.Logos.SplusObjects.DigitalInput SEEK_FORWARD;
        Crestron.Logos.SplusObjects.AnalogInput LISTITEMSCOUNT;
        Crestron.Logos.SplusObjects.AnalogInput THUMBNAILSCOUNT;
        Crestron.Logos.SplusObjects.AnalogInput FROM_IP_CLIENT_STATUS;
        Crestron.Logos.SplusObjects.AnalogInput SCROLLBAR_POSITION;
        Crestron.Logos.SplusObjects.AnalogInput PAGE_FB;
        Crestron.Logos.SplusObjects.AnalogInput DIRECT_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput NOWPLAYING_ART_HEIGHT;
        Crestron.Logos.SplusObjects.AnalogInput NOWPLAYING_ART_WIDTH;
        Crestron.Logos.SplusObjects.StringInput COMMAND__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput INSTANCE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SERVICE;
        Crestron.Logos.SplusObjects.BufferInput IP_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput TIMESTAMP__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> ART_ERROR;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> DIALOG_BUTTON;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> TITLE_SELECT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> TITLE_ADDTOPLAYLIST;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> TITLE_PLAYNOW;
        Crestron.Logos.SplusObjects.DigitalOutput TO_IP_CONNECT;
        Crestron.Logos.SplusObjects.DigitalOutput PAGE_HOME_FB;
        Crestron.Logos.SplusObjects.DigitalOutput PAGE_DETAILS_FB;
        Crestron.Logos.SplusObjects.DigitalOutput PAGE_NOWPLAYING_FB;
        Crestron.Logos.SplusObjects.DigitalOutput PAGE_THUMBNAILS_FB;
        Crestron.Logos.SplusObjects.DigitalOutput PAGE_LIST_FB;
        Crestron.Logos.SplusObjects.DigitalOutput PAGE_MOVIE_FB;
        Crestron.Logos.SplusObjects.DigitalOutput PAGE_MESSAGE_FB;
        Crestron.Logos.SplusObjects.DigitalOutput PAGE_SYNOPSIS_FB;
        Crestron.Logos.SplusObjects.DigitalOutput PAGE_CHAPTERS_FB;
        Crestron.Logos.SplusObjects.DigitalOutput PAGE_KB_FB;
        Crestron.Logos.SplusObjects.DigitalOutput REFRESH;
        Crestron.Logos.SplusObjects.DigitalOutput SEARCH_ENABLED_FB;
        Crestron.Logos.SplusObjects.DigitalOutput DIALOG_ENABLED_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ALPHA_ENABLED_FB;
        Crestron.Logos.SplusObjects.AnalogOutput ACTIONS_ENABLED_FB;
        Crestron.Logos.SplusObjects.AnalogOutput THUMBSUP_ENABLED_FB;
        Crestron.Logos.SplusObjects.AnalogOutput THUMBSDOWN_ENABLED_FB;
        Crestron.Logos.SplusObjects.AnalogOutput CHAPTERS_ENABLED_FB;
        Crestron.Logos.SplusObjects.AnalogOutput DIALOG_BUTTONS;
        Crestron.Logos.SplusObjects.AnalogOutput SHUFFLE_FB;
        Crestron.Logos.SplusObjects.AnalogOutput REPEAT_FB;
        Crestron.Logos.SplusObjects.AnalogOutput SCROLLBAR_FB;
        Crestron.Logos.SplusObjects.AnalogOutput RECORD_FB;
        Crestron.Logos.SplusObjects.AnalogOutput BACK_ENABLE;
        Crestron.Logos.SplusObjects.AnalogOutput PREV_ENABLE;
        Crestron.Logos.SplusObjects.AnalogOutput NEXT_ENABLE;
        Crestron.Logos.SplusObjects.AnalogOutput SCROLL_ENABLE;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_MEDIA_TYPE;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_TRACK_PROGRESS;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_PLAY_STATE;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_FB;
        Crestron.Logos.SplusObjects.AnalogOutput MUTE_FB;
        Crestron.Logos.SplusObjects.AnalogOutput BROWSE_ART_FORMAT;
        Crestron.Logos.SplusObjects.AnalogOutput CONFIGURAITON_FB;
        Crestron.Logos.SplusObjects.AnalogOutput BUTTON_STATE;
        Crestron.Logos.SplusObjects.AnalogOutput ALPHA_VAL_INIT;
        Crestron.Logos.SplusObjects.AnalogOutput SERVICE_LOGO_FB;
        Crestron.Logos.SplusObjects.AnalogOutput STARS_FB;
        Crestron.Logos.SplusObjects.AnalogOutput SCROBBLE_FB;
        Crestron.Logos.SplusObjects.StringOutput IP_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CAPTION;
        Crestron.Logos.SplusObjects.StringOutput IP_STATUS;
        Crestron.Logos.SplusObjects.StringOutput LIST_POSITION;
        Crestron.Logos.SplusObjects.StringOutput METADATA1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput METADATA2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput METADATA3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput METADATA4__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput METALABEL1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput METALABEL2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput METALABEL3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput METALABEL4__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TRACKLEN_FB;
        Crestron.Logos.SplusObjects.StringOutput TRACKTIME_FB;
        Crestron.Logos.SplusObjects.StringOutput TRACKTIME_SECONDS_FB;
        Crestron.Logos.SplusObjects.StringOutput NOWPLAYING_ART__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NOWPLAYING_ART_SMALL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NOWPLAYING_THUMB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NOWPLAYING_THUMB_FULL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput BROWSE_ART__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PLAYING_TRACK_NUMBER;
        Crestron.Logos.SplusObjects.StringOutput MEDIAINFO1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MEDIAINFO2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MEDIAINFO3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MEDIAINFO4__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MEDIAINFO5__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MEDIAINFO6__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MEDIAINFO7__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGECAPTION__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGETEXT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGEVALUE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONTEXT_BUTTON_1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONTEXT_BUTTON_2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONTEXT_BUTTON_3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONTEXT_BUTTON_4__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> TITLE_ENABLED;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> BUTTONTEXT;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> LISTITEM__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> LISTSUBTEXT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> LISTART__DOLLAR__;
        UShortParameter ARTSTYLE;
        UShortParameter SEEK_DELTA;
        ushort GIBUFFERACTIVE = 0;
        ushort GBIP_ISRUNNING = 0;
        ushort GBFETCHINGLIST = 0;
        ushort GBJUMP = 0;
        ushort GBDEFAULTINSTANCESET = 0;
        ushort GILISTCOUNT = 0;
        ushort GILISTINDEX = 0;
        ushort GILISTSTARTPOS = 0;
        ushort GIMAXLISTITEMS = 0;
        ushort GIMAXTHUMBNAILS = 0;
        ushort GIPAGINGVALUE = 0;
        ushort GIBROWSINGART = 0;
        ushort GIMOREITEMS = 0;
        ushort GIBUTTONSTATE = 0;
        ushort GITRACKLEN = 0;
        ushort GITRACKTIME = 0;
        ushort GITICK = 0;
        ushort GIBUSY = 0;
        ushort GIBACKAVAILABLE = 0;
        ushort GICAMEFROMLOCALMENU = 0;
        ushort GITOTALTRACKS = 0;
        ushort GIBROWSINGMEDIA = 0;
        ushort [] GICTLPORT;
        ushort GICURRENTPAGE = 0;
        ushort GISEARCH = 0;
        ushort GIKBUI = 0;
        ushort GIREPEATSTATE = 0;
        ushort GISHUFFLESTATE = 0;
        ushort GIREPEATAVAILABLE = 0;
        ushort GISHUFFLEAVAILABLE = 0;
        ushort GISEEKAVAILABLE = 0;
        ushort GIDIRECTION = 0;
        ushort GISAVEPLAYLIST = 0;
        ushort GISEARCHACTIVE = 0;
        ushort GIUICAPABILITIES = 0;
        ushort GIALPHAVAL = 0;
        ushort GISERVERHANDLESBACK = 0;
        ushort GITHUMBSUP = 0;
        ushort GITHUMBSDOWN = 0;
        ushort SUPERDEBUG = 0;
        ushort SUPPORTSMUSIC = 0;
        ushort SUPPORTSVIDEO = 0;
        ushort SUPPORTSLIVETV = 0;
        ushort SUPPORTSRECORDEDTV = 0;
        ushort SUPPORTSEPG = 0;
        ushort SUPPORTSMOVIES = 0;
        ushort SUPPORTSPICTURES = 0;
        ushort SUPPORTSRADIO = 0;
        ushort SUPPORTSVOLUME = 0;
        CrestronString GIBUFFERIN__DOLLAR__;
        CrestronString GSCONTEXT1__DOLLAR__;
        CrestronString GSCONTEXT2__DOLLAR__;
        CrestronString GSCONTEXT3__DOLLAR__;
        CrestronString GSCONTEXT4__DOLLAR__;
        CrestronString [] GSGUID;
        CrestronString [] GSITEM;
        CrestronString [] GSTYPE;
        CrestronString [] GSINSTANCE;
        CrestronString [] GSACTIONS;
        CrestronString [] GSLISTACTIONS;
        CrestronString GSLISTTYPE;
        CrestronString GSBROWSE;
        CrestronString GSFILTERS;
        CrestronString GSFILTERSDESC;
        CrestronString [] GSFILTERCONTEXT;
        CrestronString GSNOWPLAYINGGUID;
        CrestronString [] GSSERVER;
        CrestronString GSCAST;
        CrestronString [] GSMSGACTIONS;
        CrestronString GSPARENTTYPE;
        CrestronString GSARTSERVER;
        CrestronString GSNOWPLAYINGSOURCE;
        CrestronString SEEKBUILDER;
        STRUCT_HISTORY [] HISTORY;
        private void GETCONTEXTBUTTONSTATES (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 359;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GICURRENTPAGE != 4))  ) ) 
                { 
                __context__.SourceCodeLine = 361;
                GSCONTEXT1__DOLLAR__  .UpdateValue ( "Now Playing"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 365;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (GICURRENTPAGE == 4) ) && Functions.TestForTrue ( Functions.BoolToInt (CURRENT_PLAY_STATE  .Value != 0) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 367;
                    GSCONTEXT1__DOLLAR__  .UpdateValue ( "Now Playing"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 371;
                    GSCONTEXT1__DOLLAR__  .UpdateValue ( "Now Playing"  ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 376;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (GICURRENTPAGE == 3) ) && Functions.TestForTrue ( Functions.BoolToInt (GSBROWSE == "NowPlaying") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 378;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GILISTCOUNT > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 380;
                    GSCONTEXT2__DOLLAR__  .UpdateValue ( "Save Playlist"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 384;
                    GSCONTEXT2__DOLLAR__  .UpdateValue ( ""  ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 391;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CURRENT_PLAY_STATE  .Value != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 393;
                    GSCONTEXT2__DOLLAR__  .UpdateValue ( "Actions"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 397;
                    GSCONTEXT2__DOLLAR__  .UpdateValue ( ""  ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 402;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (GICURRENTPAGE == 3) ) || Functions.TestForTrue ( Functions.BoolToInt (GICURRENTPAGE == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (GISEARCH == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 404;
                GSCONTEXT3__DOLLAR__  .UpdateValue ( "Search"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 408;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (GICURRENTPAGE == 3) ) && Functions.TestForTrue ( Functions.BoolToInt (GSBROWSE == "NowPlaying") )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 410;
                    GSCONTEXT3__DOLLAR__  .UpdateValue ( "Clear Queue"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 414;
                    GSCONTEXT3__DOLLAR__  .UpdateValue ( "Favorites"  ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 420;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GICURRENTPAGE != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 422;
                GSCONTEXT4__DOLLAR__  .UpdateValue ( "Controls"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 426;
                GSCONTEXT4__DOLLAR__  .UpdateValue ( ""  ) ; 
                } 
            
            __context__.SourceCodeLine = 429;
            CONTEXT_BUTTON_1__DOLLAR__  .UpdateValue ( GSCONTEXT1__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 430;
            CONTEXT_BUTTON_2__DOLLAR__  .UpdateValue ( GSCONTEXT2__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 431;
            CONTEXT_BUTTON_3__DOLLAR__  .UpdateValue ( GSCONTEXT3__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 432;
            CONTEXT_BUTTON_4__DOLLAR__  .UpdateValue ( GSCONTEXT4__DOLLAR__  ) ; 
            
            }
            
        private void SHOWHISTORY (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 440;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 443;
                Print( "************************************************************************\r\n") ; 
                __context__.SourceCodeLine = 444;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)5; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 446;
                    Print( "History-{0:d} cmd:{1} desc:{2}\r\n", (short)I, HISTORY [ I] . COMMAND , HISTORY [ I] . DESCRIPTION ) ; 
                    __context__.SourceCodeLine = 444;
                    } 
                
                __context__.SourceCodeLine = 448;
                Print( "************************************************************************\r\n") ; 
                } 
            
            
            }
            
        private void CLEARTRANSPORT (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 455;
            METADATA1__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 456;
            METADATA2__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 457;
            METADATA3__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 458;
            METADATA4__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 460;
            TRACKLEN_FB  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 461;
            TRACKTIME_FB  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 462;
            NOWPLAYING_ART__DOLLAR__  .UpdateValue ( ""  ) ; 
            
            }
            
        private void CLEARLIST (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 468;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Max( GIMAXLISTITEMS , GIMAXTHUMBNAILS ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 470;
                TITLE_ENABLED [ I]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 471;
                LISTART__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 472;
                LISTITEM__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 473;
                LISTSUBTEXT__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 474;
                GSACTIONS [ I ]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 475;
                GSLISTACTIONS [ I ]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 468;
                } 
            
            
            }
            
        private void CLEARALL (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 481;
            CLEARLIST (  __context__  ) ; 
            __context__.SourceCodeLine = 482;
            CLEARTRANSPORT (  __context__  ) ; 
            
            }
            
        private void CLEARINFO (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 487;
            MEDIAINFO1__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 488;
            MEDIAINFO2__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 489;
            MEDIAINFO3__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 490;
            MEDIAINFO4__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 491;
            MEDIAINFO5__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 492;
            MEDIAINFO6__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 493;
            MEDIAINFO7__DOLLAR__  .UpdateValue ( ""  ) ; 
            
            }
            
        private CrestronString GETARTURL (  SplusExecutionContext __context__, CrestronString SGUID ) 
            { 
            CrestronString URL__DOLLAR__;
            URL__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            
            __context__.SourceCodeLine = 501;
            URL__DOLLAR__  .UpdateValue ( GSARTSERVER + "getart?guid=" + SGUID + "&h=112&w=112&c=2&fmt=png&nolabel=1&ticks=" + Functions.ItoA (  (int) ( Functions.GetTicks() ) ) + "&.png"  ) ; 
            __context__.SourceCodeLine = 503;
            return ( URL__DOLLAR__ ) ; 
            
            }
            
        private CrestronString PARSESERVERNAME (  SplusExecutionContext __context__, CrestronString SNAME ) 
            { 
            CrestronString NEWNAME;
            NEWNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            ushort T1 = 0;
            
            ushort T2 = 0;
            
            
            __context__.SourceCodeLine = 512;
            T1 = (ushort) ( Functions.Find( "@" , SNAME ) ) ; 
            __context__.SourceCodeLine = 513;
            T2 = (ushort) ( Functions.ReverseFind( "@" , SNAME ) ) ; 
            __context__.SourceCodeLine = 515;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( T1 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 516;
                NEWNAME  .UpdateValue ( Functions.Left ( SNAME ,  (int) ( (T1 - 1) ) )  ) ; 
                __context__.SourceCodeLine = 517;
                NEWNAME  .UpdateValue ( NEWNAME + " on "  ) ; 
                __context__.SourceCodeLine = 518;
                NEWNAME  .UpdateValue ( NEWNAME + Functions.Mid ( SNAME ,  (int) ( (T2 + 1) ) ,  (int) ( (Functions.Length( SNAME ) - T2) ) )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 520;
                NEWNAME  .UpdateValue ( SNAME  ) ; 
                } 
            
            __context__.SourceCodeLine = 521;
            ; 
            __context__.SourceCodeLine = 523;
            return ( NEWNAME ) ; 
            
            }
            
        private ushort GETLISTITEMSCOUNT (  SplusExecutionContext __context__, CrestronString IN__DOLLAR__ ) 
            { 
            ushort IPOS = 0;
            
            CrestronString SCOUNT;
            SCOUNT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            
            __context__.SourceCodeLine = 531;
            IPOS = (ushort) ( Functions.Find( "Total=" , IN__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 533;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IPOS != 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( IN__DOLLAR__ ) > (IPOS + 5) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 535;
                SCOUNT  .UpdateValue ( Functions.Mid ( IN__DOLLAR__ ,  (int) ( (IPOS + 6) ) ,  (int) ( 4 ) )  ) ; 
                __context__.SourceCodeLine = 536;
                return (ushort)( Functions.Atoi( SCOUNT )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 540;
                return (ushort)( 0) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort GETLISTSTART (  SplusExecutionContext __context__, CrestronString IN__DOLLAR__ ) 
            { 
            ushort IPOS = 0;
            
            CrestronString SSTART;
            SSTART  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            
            __context__.SourceCodeLine = 550;
            IPOS = (ushort) ( Functions.Find( "Start=" , IN__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 552;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IPOS != 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( IN__DOLLAR__ ) > (IPOS + 5) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 554;
                SSTART  .UpdateValue ( Functions.Mid ( IN__DOLLAR__ ,  (int) ( (IPOS + 6) ) ,  (int) ( 4 ) )  ) ; 
                __context__.SourceCodeLine = 555;
                return (ushort)( Functions.Atoi( SSTART )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 559;
                return (ushort)( 0) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort GETALPHAENABLE (  SplusExecutionContext __context__, CrestronString IN__DOLLAR__ ) 
            { 
            ushort IPOS = 0;
            
            CrestronString SSTART;
            SSTART  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            
            __context__.SourceCodeLine = 569;
            IPOS = (ushort) ( Functions.Find( "Alpha=" , IN__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 571;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IPOS != 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( IN__DOLLAR__ ) > (IPOS + 5) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 574;
                SSTART  .UpdateValue ( Functions.Mid ( IN__DOLLAR__ ,  (int) ( (IPOS + 6) ) ,  (int) ( 1 ) )  ) ; 
                __context__.SourceCodeLine = 575;
                return (ushort)( Functions.Atoi( SSTART )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 579;
                return (ushort)( 0) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private void PAGEFLIP (  SplusExecutionContext __context__, ushort PAGE ) 
            { 
            
            __context__.SourceCodeLine = 586;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GICURRENTPAGE != PAGE))  ) ) 
                { 
                __context__.SourceCodeLine = 588;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_1__ = ((int)PAGE);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 590;
                            Functions.Pulse ( 10, PAGE_THUMBNAILS_FB ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 591;
                            Functions.Pulse ( 10, PAGE_LIST_FB ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 592;
                            Functions.Pulse ( 10, PAGE_HOME_FB ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 593;
                            Functions.Pulse ( 10, PAGE_DETAILS_FB ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 594;
                            Functions.Pulse ( 10, PAGE_NOWPLAYING_FB ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 595;
                            Functions.Pulse ( 10, PAGE_MOVIE_FB ) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                } 
            
            __context__.SourceCodeLine = 599;
            GICURRENTPAGE = (ushort) ( PAGE ) ; 
            __context__.SourceCodeLine = 601;
            GETCONTEXTBUTTONSTATES (  __context__  ) ; 
            
            }
            
        private void PROCESSNEWLIST (  SplusExecutionContext __context__, CrestronString IN__DOLLAR__ ) 
            { 
            CrestronString STOKEN;
            STOKEN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            ushort ILAST = 0;
            
            ushort ADDICON = 0;
            
            ushort T1 = 0;
            ushort T2 = 0;
            
            
            __context__.SourceCodeLine = 613;
            CLEARLIST (  __context__  ) ; 
            __context__.SourceCodeLine = 615;
            STOKEN  .UpdateValue ( Functions.Mid ( IN__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( 128 ) )  ) ; 
            __context__.SourceCodeLine = 616;
            GSBROWSE  .UpdateValue ( Functions.Left ( STOKEN ,  (int) ( (Functions.Find( "Total" , STOKEN ) - 2) ) )  ) ; 
            __context__.SourceCodeLine = 619;
            T1 = (ushort) ( Functions.Find( "Caption=" , IN__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 620;
            T2 = (ushort) ( Functions.Find( Functions.Chr( (int)( 34 ) ) , IN__DOLLAR__ , (T1 + 9) ) ) ; 
            __context__.SourceCodeLine = 622;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( T1 > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 624;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 624;
                    Print( "Caption found") ; 
                    }
                
                __context__.SourceCodeLine = 625;
                T1 = (ushort) ( (T1 + 9) ) ; 
                __context__.SourceCodeLine = 626;
                GSFILTERSDESC  .UpdateValue ( Functions.Mid ( IN__DOLLAR__ ,  (int) ( T1 ) ,  (int) ( (T2 - T1) ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 629;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                {
                __context__.SourceCodeLine = 629;
                Print( "In: {0}\r\n", GSFILTERSDESC ) ; 
                }
            
            __context__.SourceCodeLine = 630;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                {
                __context__.SourceCodeLine = 630;
                Print( "Filter Description: {0}\r\n", GSFILTERSDESC ) ; 
                }
            
            __context__.SourceCodeLine = 634;
            GILISTCOUNT = (ushort) ( GETLISTITEMSCOUNT( __context__ , IN__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 635;
            GBFETCHINGLIST = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 636;
            GILISTINDEX = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 639;
            GILISTSTARTPOS = (ushort) ( GETLISTSTART( __context__ , IN__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 643;
            ALPHA_ENABLED_FB  .Value = (ushort) ( GETALPHAENABLE( __context__ , IN__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 647;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)1);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( Functions.BoolToInt (GSBROWSE == "Albums")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 650;
                        PAGEFLIP (  __context__ , (ushort)( 1 )) ; 
                        __context__.SourceCodeLine = 650;
                        GIPAGINGVALUE = (ushort) ( GIMAXTHUMBNAILS ) ; 
                        __context__.SourceCodeLine = 650;
                        GIBROWSINGART = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 650;
                        GISEARCH = (ushort) ( 1 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( Functions.BoolToInt (GSBROWSE == "Artists")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 651;
                        PAGEFLIP (  __context__ , (ushort)( 1 )) ; 
                        __context__.SourceCodeLine = 651;
                        GIPAGINGVALUE = (ushort) ( GIMAXTHUMBNAILS ) ; 
                        __context__.SourceCodeLine = 651;
                        GIBROWSINGART = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 651;
                        GISEARCH = (ushort) ( 1 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( Functions.BoolToInt (GSBROWSE == "Genres")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 652;
                        PAGEFLIP (  __context__ , (ushort)( 1 )) ; 
                        __context__.SourceCodeLine = 652;
                        GIPAGINGVALUE = (ushort) ( GIMAXTHUMBNAILS ) ; 
                        __context__.SourceCodeLine = 652;
                        GIBROWSINGART = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 652;
                        GISEARCH = (ushort) ( 1 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( Functions.BoolToInt (GSBROWSE == "MovieTitles")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 653;
                        PAGEFLIP (  __context__ , (ushort)( 1 )) ; 
                        __context__.SourceCodeLine = 653;
                        GIPAGINGVALUE = (ushort) ( GIMAXTHUMBNAILS ) ; 
                        __context__.SourceCodeLine = 653;
                        GIBROWSINGART = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 653;
                        GISEARCH = (ushort) ( 1 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( Functions.BoolToInt (GSBROWSE == "Pictures")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 654;
                        PAGEFLIP (  __context__ , (ushort)( 1 )) ; 
                        __context__.SourceCodeLine = 654;
                        GIPAGINGVALUE = (ushort) ( GIMAXTHUMBNAILS ) ; 
                        __context__.SourceCodeLine = 654;
                        GIBROWSINGART = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 654;
                        GISEARCH = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( Functions.BoolToInt (GSBROWSE == "Videos")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 655;
                        PAGEFLIP (  __context__ , (ushort)( 1 )) ; 
                        __context__.SourceCodeLine = 655;
                        GIPAGINGVALUE = (ushort) ( GIMAXTHUMBNAILS ) ; 
                        __context__.SourceCodeLine = 655;
                        GIBROWSINGART = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 655;
                        GISEARCH = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( Functions.BoolToInt (GSBROWSE == "DvrTitles")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 656;
                        PAGEFLIP (  __context__ , (ushort)( 1 )) ; 
                        __context__.SourceCodeLine = 656;
                        GIPAGINGVALUE = (ushort) ( GIMAXTHUMBNAILS ) ; 
                        __context__.SourceCodeLine = 656;
                        GIBROWSINGART = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 656;
                        GISEARCH = (ushort) ( 1 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( Functions.BoolToInt (GSBROWSE == "RadioStations")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 657;
                        PAGEFLIP (  __context__ , (ushort)( 1 )) ; 
                        __context__.SourceCodeLine = 657;
                        GIPAGINGVALUE = (ushort) ( GIMAXTHUMBNAILS ) ; 
                        __context__.SourceCodeLine = 657;
                        GIBROWSINGART = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 657;
                        GISEARCH = (ushort) ( 1 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( Functions.BoolToInt (GSBROWSE == "Favorites")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 658;
                        PAGEFLIP (  __context__ , (ushort)( 1 )) ; 
                        __context__.SourceCodeLine = 658;
                        GIPAGINGVALUE = (ushort) ( GIMAXTHUMBNAILS ) ; 
                        __context__.SourceCodeLine = 658;
                        GIBROWSINGART = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 658;
                        GISEARCH = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( Functions.BoolToInt (GSBROWSE == "Titles")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 659;
                        PAGEFLIP (  __context__ , (ushort)( 3 )) ; 
                        __context__.SourceCodeLine = 659;
                        GIPAGINGVALUE = (ushort) ( GIMAXLISTITEMS ) ; 
                        __context__.SourceCodeLine = 659;
                        GIBROWSINGART = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 659;
                        GISEARCH = (ushort) ( 1 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( Functions.BoolToInt (GSBROWSE == "MovieChapters")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 662;
                        PAGEFLIP (  __context__ , (ushort)( 5 )) ; 
                        __context__.SourceCodeLine = 663;
                        GIPAGINGVALUE = (ushort) ( GIMAXLISTITEMS ) ; 
                        __context__.SourceCodeLine = 664;
                        GIBROWSINGART = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 665;
                        SEARCH_ENABLED_FB  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 666;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GILISTCOUNT > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 668;
                            Functions.Pulse ( 10, PAGE_CHAPTERS_FB ) ; 
                            __context__.SourceCodeLine = 669;
                            CHAPTERS_ENABLED_FB  .Value = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 673;
                            Functions.Pulse ( 10, PAGE_SYNOPSIS_FB ) ; 
                            __context__.SourceCodeLine = 674;
                            CHAPTERS_ENABLED_FB  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 677;
                        GISEARCH = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( Functions.BoolToInt (GSBROWSE == "MoviePeople")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 679;
                        PAGEFLIP (  __context__ , (ushort)( 3 )) ; 
                        __context__.SourceCodeLine = 679;
                        GIPAGINGVALUE = (ushort) ( GIMAXLISTITEMS ) ; 
                        __context__.SourceCodeLine = 679;
                        GIBROWSINGART = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 679;
                        GISEARCH = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 681;
                        PAGEFLIP (  __context__ , (ushort)( 3 )) ; 
                        __context__.SourceCodeLine = 681;
                        GIPAGINGVALUE = (ushort) ( GIMAXLISTITEMS ) ; 
                        __context__.SourceCodeLine = 681;
                        GIBROWSINGART = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 681;
                        GISEARCH = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 685;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSFILTERSDESC == ""))  ) ) 
                {
                __context__.SourceCodeLine = 685;
                GSFILTERSDESC  .UpdateValue ( GSBROWSE  ) ; 
                }
            
            __context__.SourceCodeLine = 689;
            ILAST = (ushort) ( ((GILISTSTARTPOS + GIPAGINGVALUE) - 1) ) ; 
            __context__.SourceCodeLine = 690;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ILAST > GILISTCOUNT ))  ) ) 
                {
                __context__.SourceCodeLine = 690;
                ILAST = (ushort) ( GILISTCOUNT ) ; 
                }
            
            __context__.SourceCodeLine = 693;
            LIST_POSITION  .UpdateValue ( Functions.ItoA (  (int) ( GILISTSTARTPOS ) ) + "-" + Functions.ItoA (  (int) ( ILAST ) ) + " of " + Functions.ItoA (  (int) ( GILISTCOUNT ) )  ) ; 
            __context__.SourceCodeLine = 694;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GILISTCOUNT == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 696;
                CAPTION  .UpdateValue ( "No Items Found."  ) ; 
                __context__.SourceCodeLine = 697;
                LIST_POSITION  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 698;
                SCROLLBAR_FB  .Value = (ushort) ( 65535 ) ; 
                __context__.SourceCodeLine = 699;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSBROWSE == "MovieChapters"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 701;
                    PAGEFLIP (  __context__ , (ushort)( 5 )) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 706;
                SCROLLBAR_FB  .Value = (ushort) ( (65535 - ((65535 / GILISTCOUNT) * GILISTSTARTPOS)) ) ; 
                __context__.SourceCodeLine = 709;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSBROWSE == "NowPlaying"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 710;
                    GSFILTERSDESC  .UpdateValue ( "Now Playing List"  ) ; 
                    __context__.SourceCodeLine = 711;
                    GIBUTTONSTATE = (ushort) ( 2 ) ; 
                    __context__.SourceCodeLine = 712;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GILISTCOUNT == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 712;
                        CLEARTRANSPORT (  __context__  ) ; 
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 715;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( GSBROWSE , (int)( 8 ) ) == "Instance"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 717;
                        GSFILTERSDESC  .UpdateValue ( "Available Media Sources"  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 720;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( GSBROWSE , (int)( 9 ) ) == "DvrTitles"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 722;
                            GIBUTTONSTATE = (ushort) ( 4 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 725;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( GSBROWSE , (int)( 5 ) ) == "Movie"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 727;
                                GIBUTTONSTATE = (ushort) ( 3 ) ; 
                                __context__.SourceCodeLine = 728;
                                GSFILTERSDESC  .UpdateValue ( "Movies"  ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 733;
                                GIBUTTONSTATE = (ushort) ( 1 ) ; 
                                } 
                            
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 736;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSFILTERSDESC != ""))  ) ) 
                    {
                    __context__.SourceCodeLine = 736;
                    CAPTION  .UpdateValue ( GSFILTERSDESC  ) ; 
                    }
                
                __context__.SourceCodeLine = 737;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 737;
                    Print( "Filter Description: {0}\r\n", GSFILTERSDESC ) ; 
                    }
                
                } 
            
            
            }
            
        private CrestronString GETFIELD (  SplusExecutionContext __context__, CrestronString IN__DOLLAR__ ) 
            { 
            ushort IBYTE = 0;
            ushort IINSTRING = 0;
            ushort IINESCAPE = 0;
            
            CrestronString SGATHER;
            SGATHER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
            
            
            __context__.SourceCodeLine = 747;
            IINSTRING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 748;
            IINESCAPE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 750;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( IN__DOLLAR__ , (int)( 1 ) ) == " "))  ) ) 
                { 
                __context__.SourceCodeLine = 750;
                IBYTE = (ushort) ( Functions.GetC( IN__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 750;
                } 
            
            __context__.SourceCodeLine = 752;
            do 
                { 
                __context__.SourceCodeLine = 754;
                IBYTE = (ushort) ( Functions.GetC( IN__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 756;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_3__ = ((int)1);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( Functions.BoolToInt (IBYTE == 32)) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 760;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINSTRING == 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 761;
                                IBYTE = (ushort) ( 65535 ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 763;
                                SGATHER  .UpdateValue ( SGATHER + " "  ) ; 
                                }
                            
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( Functions.BoolToInt (IBYTE == 34)) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 768;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINSTRING == 1))  ) ) 
                                { 
                                __context__.SourceCodeLine = 769;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINESCAPE == 1))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 770;
                                    SGATHER  .UpdateValue ( SGATHER + "\""  ) ; 
                                    __context__.SourceCodeLine = 771;
                                    IINESCAPE = (ushort) ( 0 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 774;
                                    IBYTE = (ushort) ( 65535 ) ; 
                                    } 
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 778;
                                IINSTRING = (ushort) ( 1 ) ; 
                                } 
                            
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( Functions.BoolToInt (IBYTE == 92)) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 783;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINESCAPE == 1))  ) ) 
                                { 
                                __context__.SourceCodeLine = 784;
                                SGATHER  .UpdateValue ( SGATHER + "\\"  ) ; 
                                __context__.SourceCodeLine = 785;
                                IINESCAPE = (ushort) ( 0 ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 787;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINSTRING == 1))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 788;
                                    IINESCAPE = (ushort) ( 1 ) ; 
                                    } 
                                
                                }
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 793;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IBYTE != 65535) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( SGATHER ) < 2048 ) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 795;
                                SGATHER  .UpdateValue ( SGATHER + Functions.Chr (  (int) ( IBYTE ) )  ) ; 
                                __context__.SourceCodeLine = 796;
                                IINESCAPE = (ushort) ( 0 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 800;
                                IBYTE = (ushort) ( 65535 ) ; 
                                } 
                            
                            } 
                        
                        } 
                        
                    }
                    
                
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (IBYTE == 65535)) )); 
            __context__.SourceCodeLine = 807;
            return ( SGATHER ) ; 
            
            }
            
        private void GETKBINPUTUI (  SplusExecutionContext __context__, CrestronString PARMS ) 
            { 
            CrestronString GUID;
            GUID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
            
            CrestronString CAPTION;
            CAPTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            CrestronString MESSAGE;
            MESSAGE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            CrestronString TIMEOUT;
            TIMEOUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            CrestronString VALUE;
            VALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            
            __context__.SourceCodeLine = 819;
            GUID  .UpdateValue ( GETFIELD (  __context__ , PARMS)  ) ; 
            __context__.SourceCodeLine = 820;
            CAPTION  .UpdateValue ( GETFIELD (  __context__ , PARMS)  ) ; 
            __context__.SourceCodeLine = 821;
            MESSAGE  .UpdateValue ( GETFIELD (  __context__ , PARMS)  ) ; 
            __context__.SourceCodeLine = 822;
            VALUE  .UpdateValue ( GETFIELD (  __context__ , PARMS)  ) ; 
            __context__.SourceCodeLine = 823;
            TIMEOUT  .UpdateValue ( GETFIELD (  __context__ , PARMS)  ) ; 
            __context__.SourceCodeLine = 828;
            GSMSGACTIONS [ 1 ]  .UpdateValue ( GETFIELD (  __context__ , PARMS)  ) ; 
            __context__.SourceCodeLine = 829;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value != 0))  ) ) 
                {
                __context__.SourceCodeLine = 829;
                Print( "Ack Action: {0}\r", GSMSGACTIONS [ 1 ] ) ; 
                }
            
            __context__.SourceCodeLine = 832;
            MESSAGETEXT__DOLLAR__  .UpdateValue ( MESSAGE  ) ; 
            __context__.SourceCodeLine = 833;
            MESSAGECAPTION__DOLLAR__  .UpdateValue ( CAPTION  ) ; 
            __context__.SourceCodeLine = 834;
            MESSAGEVALUE__DOLLAR__  .UpdateValue ( VALUE  ) ; 
            __context__.SourceCodeLine = 838;
            Functions.Pulse ( 10, PAGE_KB_FB ) ; 
            __context__.SourceCodeLine = 841;
            GIKBUI = (ushort) ( 1 ) ; 
            
            }
            
        private ushort GETFIRSTCHAR (  SplusExecutionContext __context__, CrestronString IN__DOLLAR__ ) 
            { 
            CrestronString TEMP__DOLLAR__;
            TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            ushort TEMP = 0;
            
            
            __context__.SourceCodeLine = 852;
            if ( Functions.TestForTrue  ( ( Functions.Find( "The " , IN__DOLLAR__ ))  ) ) 
                {
                __context__.SourceCodeLine = 853;
                TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "The " , IN__DOLLAR__ , 1)  ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 854;
                if ( Functions.TestForTrue  ( ( Functions.Find( "A " , IN__DOLLAR__ ))  ) ) 
                    {
                    __context__.SourceCodeLine = 855;
                    TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "A " , IN__DOLLAR__ )  ) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 857;
            TEMP = (ushort) ( Functions.GetC( IN__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 859;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                {
                __context__.SourceCodeLine = 859;
                Print( "Character is {0}\u000D", Functions.ItoA (  (int) ( TEMP ) ) ) ; 
                }
            
            __context__.SourceCodeLine = 861;
            return (ushort)( TEMP) ; 
            
            }
            
        private void PROCESSLISTITEM (  SplusExecutionContext __context__, CrestronString IN__DOLLAR__ ) 
            { 
            CrestronString STYPE;
            CrestronString SSUBTEXT;
            CrestronString SURL;
            CrestronString STRASH;
            CrestronString SPORT;
            STYPE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 25, this );
            SSUBTEXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            SURL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            STRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
            SPORT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            CrestronString STIME;
            CrestronString SARTIST;
            CrestronString SALBUM;
            CrestronString STRACK;
            STIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
            SARTIST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            SALBUM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            STRACK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            CrestronString DESCRIPTION;
            DESCRIPTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            CrestronString ICON;
            ICON  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
            
            CrestronString HASCHILDREN;
            HASCHILDREN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
            
            CrestronString ACTION;
            ACTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            CrestronString TEMP__DOLLAR__;
            TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
            
            ushort LISTINDEX = 0;
            ushort P1 = 0;
            ushort P2 = 0;
            
            
            __context__.SourceCodeLine = 878;
            LISTINDEX = (ushort) ( GILISTINDEX ) ; 
            __context__.SourceCodeLine = 880;
            GILISTINDEX = (ushort) ( (GILISTINDEX + 1) ) ; 
            __context__.SourceCodeLine = 881;
            IN__DOLLAR__  .UpdateValue ( Functions.Right ( IN__DOLLAR__ ,  (int) ( (Functions.Length( IN__DOLLAR__ ) - 2) ) )  ) ; 
            __context__.SourceCodeLine = 883;
            GSTYPE [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
            __context__.SourceCodeLine = 884;
            GSGUID [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
            __context__.SourceCodeLine = 885;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( GSGUID[ GILISTINDEX ] , (int)( 1 ) ) == "{"))  ) ) 
                {
                __context__.SourceCodeLine = 885;
                GSGUID [ GILISTINDEX ]  .UpdateValue ( Functions.Mid ( GSGUID [ GILISTINDEX ] ,  (int) ( 2 ) ,  (int) ( (Functions.Length( GSGUID[ GILISTINDEX ] ) - 2) ) )  ) ; 
                }
            
            __context__.SourceCodeLine = 886;
            GSITEM [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
            __context__.SourceCodeLine = 890;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (GSGUID[ GILISTINDEX ] == "") ) && Functions.TestForTrue ( Functions.BoolToInt (GSITEM[ GILISTINDEX ] == "") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 892;
                GSITEM [ GILISTINDEX ]  .UpdateValue ( GSTYPE [ GILISTINDEX ]  ) ; 
                __context__.SourceCodeLine = 893;
                GSTYPE [ GILISTINDEX ]  .UpdateValue ( "Instance"  ) ; 
                __context__.SourceCodeLine = 894;
                GIBUTTONSTATE = (ushort) ( 6 ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 898;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSTYPE[ GILISTINDEX ] == "Title"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 901;
                    STIME  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                    __context__.SourceCodeLine = 902;
                    STRACK  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                    __context__.SourceCodeLine = 903;
                    SARTIST  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                    __context__.SourceCodeLine = 904;
                    SALBUM  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                    __context__.SourceCodeLine = 906;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STIME != "00:00:00"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 908;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( STIME , (int)( 3 ) ) == "00:"))  ) ) 
                            {
                            __context__.SourceCodeLine = 908;
                            STIME  .UpdateValue ( Functions.Mid ( STIME ,  (int) ( 4 ) ,  (int) ( 5 ) )  ) ; 
                            }
                        
                        __context__.SourceCodeLine = 909;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( STIME , (int)( 1 ) ) == "0"))  ) ) 
                            {
                            __context__.SourceCodeLine = 909;
                            STIME  .UpdateValue ( Functions.Mid ( STIME ,  (int) ( 2 ) ,  (int) ( 4 ) )  ) ; 
                            }
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 913;
                        STIME  .UpdateValue ( ""  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 916;
                    SSUBTEXT  .UpdateValue ( SARTIST + "  " + STIME  ) ; 
                    __context__.SourceCodeLine = 918;
                    ICON  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                    __context__.SourceCodeLine = 920;
                    GSACTIONS [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                    __context__.SourceCodeLine = 921;
                    GSLISTACTIONS [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 925;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSTYPE[ GILISTINDEX ] == "Album"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 927;
                        P2 = (ushort) ( Functions.ReverseFind( ")" , GSITEM[ GILISTINDEX ] ) ) ; 
                        __context__.SourceCodeLine = 928;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (P2 != 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 928;
                            P1 = (ushort) ( Functions.ReverseFind( "(" , GSITEM[ GILISTINDEX ] , (P2 - 1) ) ) ; 
                            }
                        
                        __context__.SourceCodeLine = 929;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (P1 != 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( P2 > (P1 + 1) ) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 931;
                            SSUBTEXT  .UpdateValue ( Functions.Mid ( GSITEM [ GILISTINDEX ] ,  (int) ( (P1 + 1) ) ,  (int) ( ((P2 - P1) - 1) ) )  ) ; 
                            __context__.SourceCodeLine = 932;
                            GSITEM [ GILISTINDEX ]  .UpdateValue ( Functions.Left ( GSITEM [ GILISTINDEX ] ,  (int) ( (P1 - 1) ) )  ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 935;
                        ICON  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                        __context__.SourceCodeLine = 936;
                        GSLISTACTIONS [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                        __context__.SourceCodeLine = 937;
                        GSACTIONS [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 942;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSTYPE[ GILISTINDEX ] == "InstanceInfoEx"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 944;
                            SPORT  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                            __context__.SourceCodeLine = 945;
                            STRASH  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                            __context__.SourceCodeLine = 946;
                            SSUBTEXT  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 947;
                            GSSERVER [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                            __context__.SourceCodeLine = 948;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                                {
                                __context__.SourceCodeLine = 948;
                                Print( "Server:{0}\r\n", GSSERVER [ GILISTINDEX ] ) ; 
                                }
                            
                            __context__.SourceCodeLine = 949;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                                {
                                __context__.SourceCodeLine = 949;
                                Print( "Item:{0}\r\n", GSITEM [ GILISTINDEX ] ) ; 
                                }
                            
                            __context__.SourceCodeLine = 950;
                            GICTLPORT [ GILISTINDEX] = (ushort) ( Functions.Atoi( SPORT ) ) ; 
                            __context__.SourceCodeLine = 951;
                            GSINSTANCE [ GILISTINDEX ]  .UpdateValue ( Functions.Left ( GSITEM [ GILISTINDEX ] ,  (int) ( (Functions.ReverseFind( "@" , GSITEM[ GILISTINDEX ] ) - 1) ) )  ) ; 
                            __context__.SourceCodeLine = 952;
                            GSITEM [ GILISTINDEX ]  .UpdateValue ( PARSESERVERNAME (  __context__ , GSITEM[ GILISTINDEX ])  ) ; 
                            __context__.SourceCodeLine = 953;
                            GIBUTTONSTATE = (ushort) ( 6 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 957;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSTYPE[ GILISTINDEX ] == "RadioStation"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 960;
                                DESCRIPTION  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                __context__.SourceCodeLine = 961;
                                ICON  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                __context__.SourceCodeLine = 962;
                                ACTION  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                __context__.SourceCodeLine = 963;
                                GSLISTACTIONS [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                __context__.SourceCodeLine = 965;
                                GIBUTTONSTATE = (ushort) ( 6 ) ; 
                                __context__.SourceCodeLine = 983;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ACTION != ""))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 983;
                                    GSACTIONS [ GILISTINDEX ]  .UpdateValue ( ACTION  ) ; 
                                    }
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 987;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSTYPE[ GILISTINDEX ] == "Favorite"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 989;
                                    DESCRIPTION  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                    __context__.SourceCodeLine = 990;
                                    ICON  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                    __context__.SourceCodeLine = 991;
                                    GSACTIONS [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                    __context__.SourceCodeLine = 992;
                                    GSLISTACTIONS [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                    __context__.SourceCodeLine = 993;
                                    GIBUTTONSTATE = (ushort) ( 2 ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 997;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSTYPE[ GILISTINDEX ] == "EpgStation"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 999;
                                        SSUBTEXT  .UpdateValue ( ""  ) ; 
                                        __context__.SourceCodeLine = 1000;
                                        GSITEM [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__) + " " + GSITEM [ GILISTINDEX ]  ) ; 
                                        __context__.SourceCodeLine = 1001;
                                        STRASH  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                        __context__.SourceCodeLine = 1002;
                                        GSITEM [ GILISTINDEX ]  .UpdateValue ( GSITEM [ GILISTINDEX ] + " " + GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1006;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (GSTYPE[ GILISTINDEX ] == "PictureFile") ) || Functions.TestForTrue ( Functions.BoolToInt (GSTYPE[ GILISTINDEX ] == "VideoFile") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (GSTYPE[ GILISTINDEX ] == "PictureFolder") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (GSTYPE[ GILISTINDEX ] == "VideoFolder") )) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1008;
                                            SSUBTEXT  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 1009;
                                            GSITEM [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                            __context__.SourceCodeLine = 1011;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSTYPE[ GILISTINDEX ] == "VideoFolder"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1013;
                                                GIBUTTONSTATE = (ushort) ( 6 ) ; 
                                                } 
                                            
                                            else 
                                                { 
                                                __context__.SourceCodeLine = 1017;
                                                GIBUTTONSTATE = (ushort) ( 4 ) ; 
                                                } 
                                            
                                            __context__.SourceCodeLine = 1020;
                                            ICON  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                            __context__.SourceCodeLine = 1021;
                                            GSLISTACTIONS [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                            __context__.SourceCodeLine = 1022;
                                            GSACTIONS [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1027;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "Filter" , GSTYPE[ GILISTINDEX ] ) > 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "RadioSource" , GSTYPE[ GILISTINDEX ] ) > 0 ) )) ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1029;
                                                GIBUTTONSTATE = (ushort) ( 6 ) ; 
                                                __context__.SourceCodeLine = 1030;
                                                ICON  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                                __context__.SourceCodeLine = 1031;
                                                GSACTIONS [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                                __context__.SourceCodeLine = 1032;
                                                GSLISTACTIONS [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1036;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSTYPE[ GILISTINDEX ] == "PickListItem"))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1039;
                                                    HASCHILDREN  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                                    __context__.SourceCodeLine = 1040;
                                                    ICON  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                                    __context__.SourceCodeLine = 1041;
                                                    GSACTIONS [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                                    __context__.SourceCodeLine = 1042;
                                                    GSLISTACTIONS [ GILISTINDEX ]  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
                                                    __context__.SourceCodeLine = 1044;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICON == "6"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1046;
                                                        GIBUTTONSTATE = (ushort) ( 5 ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1048;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICON == "2"))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1050;
                                                            GIBUTTONSTATE = (ushort) ( 2 ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1052;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ICON == "-1") ) || Functions.TestForTrue ( Functions.BoolToInt (ICON == "0") )) ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1054;
                                                                GIBUTTONSTATE = (ushort) ( 6 ) ; 
                                                                } 
                                                            
                                                            else 
                                                                { 
                                                                __context__.SourceCodeLine = 1058;
                                                                GIBUTTONSTATE = (ushort) ( 0 ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1063;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSTYPE[ GILISTINDEX ] == "RadioGenre"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1065;
                                                        GIBUTTONSTATE = (ushort) ( 6 ) ; 
                                                        } 
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 1070;
            LISTITEM__DOLLAR__ [ GILISTINDEX]  .UpdateValue ( GSITEM [ GILISTINDEX ]  ) ; 
            __context__.SourceCodeLine = 1072;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LISTINDEX == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1075;
                TEMP__DOLLAR__  .UpdateValue ( GSITEM [ LISTINDEX ]  ) ; 
                __context__.SourceCodeLine = 1076;
                ALPHA_VAL_INIT  .Value = (ushort) ( GETFIRSTCHAR( __context__ , TEMP__DOLLAR__ ) ) ; 
                } 
            
            __context__.SourceCodeLine = 1080;
            LISTSUBTEXT__DOLLAR__ [ GILISTINDEX]  .UpdateValue ( SSUBTEXT  ) ; 
            __context__.SourceCodeLine = 1081;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GIBROWSINGART == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1083;
                SURL  .UpdateValue ( GETARTURL (  __context__ , GSGUID[ GILISTINDEX ])  ) ; 
                __context__.SourceCodeLine = 1084;
                LISTART__DOLLAR__ [ GILISTINDEX]  .UpdateValue ( SURL  ) ; 
                } 
            
            __context__.SourceCodeLine = 1088;
            TITLE_ENABLED [ GILISTINDEX]  .Value = (ushort) ( GIBUTTONSTATE ) ; 
            
            }
            
        private void PROCESSMOVIEPROPERTY (  SplusExecutionContext __context__, CrestronString IN__DOLLAR__ ) 
            { 
            CrestronString TRASH;
            CrestronString PROPERTY;
            CrestronString VALUE;
            CrestronString CHUNK;
            TRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 25, this );
            PROPERTY  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 12, this );
            VALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
            CHUNK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            ushort T1 = 0;
            
            
            __context__.SourceCodeLine = 1096;
            TRASH  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
            __context__.SourceCodeLine = 1097;
            VALUE  .UpdateValue ( GETFIELD (  __context__ , IN__DOLLAR__)  ) ; 
            __context__.SourceCodeLine = 1098;
            T1 = (ushort) ( Functions.Find( "=" , VALUE ) ) ; 
            __context__.SourceCodeLine = 1099;
            PROPERTY  .UpdateValue ( Functions.Left ( VALUE ,  (int) ( (T1 - 1) ) )  ) ; 
            __context__.SourceCodeLine = 1100;
            VALUE  .UpdateValue ( Functions.Mid ( VALUE ,  (int) ( (T1 + 1) ) ,  (int) ( (Functions.Length( VALUE ) - T1) ) )  ) ; 
            __context__.SourceCodeLine = 1102;
            
                {
                int __SPLS_TMPVAR__SWTCH_4__ = ((int)1);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( Functions.BoolToInt (PROPERTY == "Actors")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1106;
                        VALUE  .UpdateValue ( Functions.Left ( VALUE ,  (int) ( (Functions.ReverseFind( ";" , VALUE , 128 ) - 1) ) )  ) ; 
                        __context__.SourceCodeLine = 1107;
                        MEDIAINFO6__DOLLAR__  .UpdateValue ( VALUE  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( Functions.BoolToInt (PROPERTY == "Synopsis")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1112;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( VALUE ) > 600 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1114;
                            VALUE  .UpdateValue ( Functions.Left ( VALUE ,  (int) ( 600 ) )  ) ; 
                            __context__.SourceCodeLine = 1115;
                            VALUE  .UpdateValue ( Functions.Left ( VALUE ,  (int) ( Functions.ReverseFind( "." , VALUE ) ) )  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 1119;
                            Print( "Value Length = {0:d}", (short)Functions.Length( VALUE )) ; 
                            } 
                        
                        __context__.SourceCodeLine = 1121;
                        MEDIAINFO7__DOLLAR__  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 1122;
                        while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( VALUE ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1124;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( VALUE ) > 100 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1126;
                                CHUNK  .UpdateValue ( Functions.Remove ( 100, VALUE )  ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 1130;
                                CHUNK  .UpdateValue ( VALUE  ) ; 
                                __context__.SourceCodeLine = 1131;
                                VALUE  .UpdateValue ( ""  ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 1134;
                            MEDIAINFO7__DOLLAR__  .UpdateValue ( "\u00FE\u0002" + CHUNK  ) ; 
                            __context__.SourceCodeLine = 1122;
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( Functions.BoolToInt (PROPERTY == "Name")) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1137;
                        MEDIAINFO1__DOLLAR__  .UpdateValue ( VALUE  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( Functions.BoolToInt (PROPERTY == "Genre")) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1138;
                        MEDIAINFO2__DOLLAR__  .UpdateValue ( VALUE  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( Functions.BoolToInt (PROPERTY == "Rating")) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1139;
                        MEDIAINFO3__DOLLAR__  .UpdateValue ( VALUE  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( Functions.BoolToInt (PROPERTY == "Minutes")) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1140;
                        MEDIAINFO4__DOLLAR__  .UpdateValue ( VALUE + " Minutes"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( Functions.BoolToInt (PROPERTY == "Year")) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1141;
                        MEDIAINFO5__DOLLAR__  .UpdateValue ( VALUE  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            
            }
            
        private void PROCESSLISTEND (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 1149;
            NEXT_ENABLE  .Value = (ushort) ( GIMOREITEMS ) ; 
            __context__.SourceCodeLine = 1150;
            SCROLL_ENABLE  .Value = (ushort) ( Functions.BoolToInt ( (Functions.TestForTrue ( NEXT_ENABLE  .Value ) || Functions.TestForTrue ( PREV_ENABLE  .Value )) ) ) ; 
            __context__.SourceCodeLine = 1152;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( (GILISTINDEX + 1) ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Max( GIMAXLISTITEMS , GIMAXTHUMBNAILS ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 1154;
                TITLE_ENABLED [ I]  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1152;
                } 
            
            __context__.SourceCodeLine = 1157;
            GBFETCHINGLIST = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1158;
            GIBUSY = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1160;
            SEARCH_ENABLED_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1161;
            SEARCH_ENABLED_FB  .Value = (ushort) ( GISEARCH ) ; 
            __context__.SourceCodeLine = 1163;
            GETCONTEXTBUTTONSTATES (  __context__  ) ; 
            __context__.SourceCodeLine = 1165;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                {
                __context__.SourceCodeLine = 1165;
                Print( "List processed") ; 
                }
            
            
            }
            
        private ushort STOB (  SplusExecutionContext __context__, CrestronString BOOL__DOLLAR__ ) 
            { 
            
            __context__.SourceCodeLine = 1170;
            
                {
                int __SPLS_TMPVAR__SWTCH_5__ = ((int)1);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (BOOL__DOLLAR__ == "True") ) || Functions.TestForTrue ( Functions.BoolToInt (BOOL__DOLLAR__ == "T") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (BOOL__DOLLAR__ == "t") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (BOOL__DOLLAR__ == "1") )) )) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1172;
                        return (ushort)( 1) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1173;
                        return (ushort)( 0) ; 
                        }
                    
                    } 
                    
                }
                
            
            
            return 0; // default return value (none specified in module)
            }
            
        private CrestronString MAKETIMESTRING (  SplusExecutionContext __context__, CrestronString SECS__DOLLAR__ ) 
            { 
            CrestronString TIME__DOLLAR__;
            TIME__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            ushort HOUR = 0;
            ushort MINS = 0;
            ushort SEC = 0;
            
            
            __context__.SourceCodeLine = 1183;
            SEC = (ushort) ( Functions.Atoi( SECS__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 1184;
            MINS = (ushort) ( (SEC / 60) ) ; 
            __context__.SourceCodeLine = 1185;
            SEC = (ushort) ( Mod( SEC , 60 ) ) ; 
            __context__.SourceCodeLine = 1186;
            HOUR = (ushort) ( (MINS / 60) ) ; 
            __context__.SourceCodeLine = 1187;
            MINS = (ushort) ( Mod( MINS , 60 ) ) ; 
            __context__.SourceCodeLine = 1189;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HOUR > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1189;
                MakeString ( TIME__DOLLAR__ , "{0:d}:{1:d2}:{2:d2}", (short)HOUR, (short)MINS, (short)SEC) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1190;
                MakeString ( TIME__DOLLAR__ , "{0:d}:{1:d2}", (short)MINS, (short)SEC) ; 
                } 
            
            __context__.SourceCodeLine = 1192;
            return ( TIME__DOLLAR__ ) ; 
            
            }
            
        private void SETTRACKLEN (  SplusExecutionContext __context__, CrestronString SECS__DOLLAR__ ) 
            { 
            
            __context__.SourceCodeLine = 1197;
            GITRACKLEN = (ushort) ( Functions.Atoi( SECS__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 1198;
            TRACKLEN_FB  .UpdateValue ( MAKETIMESTRING (  __context__ , SECS__DOLLAR__)  ) ; 
            
            }
            
        private void SETTRACKTIME (  SplusExecutionContext __context__, CrestronString SECS__DOLLAR__ ) 
            { 
            
            __context__.SourceCodeLine = 1203;
            GITRACKTIME = (ushort) ( Functions.Atoi( SECS__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 1204;
            TRACKTIME_SECONDS_FB  .UpdateValue ( SECS__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 1205;
            TRACKTIME_FB  .UpdateValue ( MAKETIMESTRING (  __context__ , SECS__DOLLAR__)  ) ; 
            __context__.SourceCodeLine = 1207;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GITRACKLEN != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1208;
                CURRENT_TRACK_PROGRESS  .Value = (ushort) ( ((65535 / GITRACKLEN) * GITRACKTIME) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1210;
                CURRENT_TRACK_PROGRESS  .Value = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 1212;
            GITICK = (ushort) ( (GITICK + 1) ) ; 
            __context__.SourceCodeLine = 1213;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( GITICK >= 600 ) ) && Functions.TestForTrue ( Functions.BoolToInt (GIKBUI != 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1215;
                PAGEFLIP (  __context__ , (ushort)( 4 )) ; 
                __context__.SourceCodeLine = 1216;
                SEARCH_ENABLED_FB  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1217;
                GITICK = (ushort) ( 0 ) ; 
                } 
            
            
            }
            
        private void SHOWMESSAGEBOX (  SplusExecutionContext __context__, CrestronString PARMS ) 
            { 
            CrestronString GUID;
            GUID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            CrestronString CAPTION;
            CAPTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            CrestronString MESSAGE;
            MESSAGE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
            
            CrestronString TIMEOUT;
            TIMEOUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            CrestronString ACTION;
            ACTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
            
            CrestronString BUTTONCAPTION;
            BUTTONCAPTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
            
            CrestronString DEFAULTBUTTON;
            DEFAULTBUTTON  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
            
            ushort I = 0;
            
            ushort BUTTONS = 0;
            
            
            __context__.SourceCodeLine = 1233;
            GUID  .UpdateValue ( GETFIELD (  __context__ , PARMS)  ) ; 
            __context__.SourceCodeLine = 1234;
            CAPTION  .UpdateValue ( GETFIELD (  __context__ , PARMS)  ) ; 
            __context__.SourceCodeLine = 1235;
            MESSAGE  .UpdateValue ( GETFIELD (  __context__ , PARMS)  ) ; 
            __context__.SourceCodeLine = 1236;
            TIMEOUT  .UpdateValue ( GETFIELD (  __context__ , PARMS)  ) ; 
            __context__.SourceCodeLine = 1238;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1240;
                Print( "guid: {0}", GUID ) ; 
                __context__.SourceCodeLine = 1241;
                Print( "caption: {0}", CAPTION ) ; 
                __context__.SourceCodeLine = 1242;
                Print( "message: {0}", MESSAGE ) ; 
                __context__.SourceCodeLine = 1243;
                Print( "timeout: {0}", TIMEOUT ) ; 
                } 
            
            __context__.SourceCodeLine = 1246;
            MESSAGECAPTION__DOLLAR__  .UpdateValue ( CAPTION  ) ; 
            __context__.SourceCodeLine = 1247;
            MESSAGETEXT__DOLLAR__  .UpdateValue ( Functions.Left ( MESSAGE ,  (int) ( 250 ) )  ) ; 
            __context__.SourceCodeLine = 1249;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)3; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 1251;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( PARMS ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1253;
                    BUTTONCAPTION  .UpdateValue ( GETFIELD (  __context__ , PARMS)  ) ; 
                    __context__.SourceCodeLine = 1254;
                    ACTION  .UpdateValue ( GETFIELD (  __context__ , PARMS)  ) ; 
                    __context__.SourceCodeLine = 1255;
                    DEFAULTBUTTON  .UpdateValue ( GETFIELD (  __context__ , PARMS)  ) ; 
                    __context__.SourceCodeLine = 1256;
                    GSMSGACTIONS [ I ]  .UpdateValue ( ACTION  ) ; 
                    __context__.SourceCodeLine = 1257;
                    BUTTONTEXT [ I]  .UpdateValue ( BUTTONCAPTION  ) ; 
                    __context__.SourceCodeLine = 1258;
                    BUTTONS = (ushort) ( I ) ; 
                    } 
                
                __context__.SourceCodeLine = 1249;
                } 
            
            __context__.SourceCodeLine = 1262;
            DIALOG_BUTTONS  .Value = (ushort) ( BUTTONS ) ; 
            __context__.SourceCodeLine = 1263;
            DIALOG_ENABLED_FB  .Value = (ushort) ( 1 ) ; 
            
            }
            
        private void SHOWINSTANTMESSAGEBOXWAIT (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1268;
            CreateWait ( "MESSAGEBOXDISPLAY" , 500 , MESSAGEBOXDISPLAY_Callback ) ;
            
            }
            
        public void MESSAGEBOXDISPLAY_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 1270;
            DIALOG_ENABLED_FB  .Value = (ushort) ( 0 ) ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    private void SHOWINSTANTMESSAGEBOX (  SplusExecutionContext __context__, CrestronString CAPTION , CrestronString MESSAGE ) 
        { 
        
        __context__.SourceCodeLine = 1277;
        CancelWait ( "MESSAGEBOXDISPLAY" ) ; 
        __context__.SourceCodeLine = 1279;
        MESSAGECAPTION__DOLLAR__  .UpdateValue ( CAPTION  ) ; 
        __context__.SourceCodeLine = 1280;
        MESSAGETEXT__DOLLAR__  .UpdateValue ( MESSAGE  ) ; 
        __context__.SourceCodeLine = 1281;
        DIALOG_BUTTONS  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1282;
        DIALOG_ENABLED_FB  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1284;
        SHOWINSTANTMESSAGEBOXWAIT (  __context__  ) ; 
        
        }
        
    private void CLEARDIALOGS (  SplusExecutionContext __context__ ) 
        { 
        ushort G = 0;
        
        
        __context__.SourceCodeLine = 1290;
        DIALOG_ENABLED_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1291;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)3; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( G  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (G  >= __FN_FORSTART_VAL__1) && (G  <= __FN_FOREND_VAL__1) ) : ( (G  <= __FN_FORSTART_VAL__1) && (G  >= __FN_FOREND_VAL__1) ) ; G  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1292;
            BUTTONTEXT [ G]  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1291;
            } 
        
        __context__.SourceCodeLine = 1295;
        MESSAGECAPTION__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 1296;
        MESSAGETEXT__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        }
        
    private void REFRESH_NOWPLAYING_ART (  SplusExecutionContext __context__ ) 
        { 
        
        __context__.SourceCodeLine = 1303;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARTSTYLE  .Value == 0))  ) ) 
            {
            __context__.SourceCodeLine = 1304;
            NOWPLAYING_ART__DOLLAR__  .UpdateValue ( GSARTSERVER + "getart?guid=" + GSNOWPLAYINGGUID + "&h=" + Functions.ItoA (  (int) ( NOWPLAYING_ART_HEIGHT  .UshortValue ) ) + "&w=" + Functions.ItoA (  (int) ( NOWPLAYING_ART_WIDTH  .UshortValue ) ) + "&c=1&fmt=png&tod=" + TIMESTAMP__DOLLAR__ + "&.png"  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1306;
            NOWPLAYING_ART__DOLLAR__  .UpdateValue ( GSARTSERVER + "getart?guid=" + GSNOWPLAYINGGUID + "&h=" + Functions.ItoA (  (int) ( NOWPLAYING_ART_HEIGHT  .UshortValue ) ) + "&w=" + Functions.ItoA (  (int) ( NOWPLAYING_ART_WIDTH  .UshortValue ) ) + "&c=1&rfle=3&rflh=30&rflo=70&rz=15&fmt=png&tod=" + TIMESTAMP__DOLLAR__ + "&.png"  ) ; 
            }
        
        __context__.SourceCodeLine = 1308;
        NOWPLAYING_ART_SMALL__DOLLAR__  .UpdateValue ( GSARTSERVER + "getart?guid=" + GSNOWPLAYINGGUID + "&h=130&w=91&c=1&rfle=3&rflh=30&rflo=40&rz=15&fmt=png&tod=" + TIMESTAMP__DOLLAR__ + "&.png"  ) ; 
        __context__.SourceCodeLine = 1309;
        NOWPLAYING_THUMB__DOLLAR__  .UpdateValue ( GSARTSERVER + "getart?guid=" + GSNOWPLAYINGGUID + "&h=107&w=107&c=1&fmt=png&tod=" + TIMESTAMP__DOLLAR__ + "&.png"  ) ; 
        __context__.SourceCodeLine = 1310;
        NOWPLAYING_THUMB_FULL__DOLLAR__  .UpdateValue ( GSARTSERVER + "getart?guid=" + GSNOWPLAYINGGUID + "&h=" + Functions.ItoA (  (int) ( NOWPLAYING_ART_HEIGHT  .UshortValue ) ) + "&w=" + Functions.ItoA (  (int) ( NOWPLAYING_ART_WIDTH  .UshortValue ) ) + "&c=1&fmt=png&tod=" + TIMESTAMP__DOLLAR__ + "&.png"  ) ; 
        
        }
        
    private void REFRESH_BROWSING_ART (  SplusExecutionContext __context__, CrestronString SGUID ) 
        { 
        
        __context__.SourceCodeLine = 1316;
        BROWSE_ART__DOLLAR__  .UpdateValue ( GSARTSERVER + "getart?guid=" + SGUID + "&h=200&w=156&c=1&rfle=3&rflh=30&rflo=40&rz=15&fmt=png&tod=" + TIMESTAMP__DOLLAR__ + "&.png"  ) ; 
        
        }
        
    private ushort SUPPORTSMUSICONLY (  SplusExecutionContext __context__ ) 
        { 
        
        __context__.SourceCodeLine = 1321;
        return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( SUPPORTSMUSIC ) && Functions.TestForTrue ( Functions.BoolToInt (SUPPORTSVIDEO == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (SUPPORTSRECORDEDTV == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (SUPPORTSMOVIES == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (SUPPORTSPICTURES == 0) )) )) ; 
        
        }
        
    private void UPDATEUICAPIBILITIES (  SplusExecutionContext __context__ ) 
        { 
        
        __context__.SourceCodeLine = 1327;
        GIUICAPABILITIES = (ushort) ( SUPPORTSMUSICONLY( __context__ ) ) ; 
        __context__.SourceCodeLine = 1328;
        CONFIGURAITON_FB  .Value = (ushort) ( GIUICAPABILITIES ) ; 
        __context__.SourceCodeLine = 1329;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GIUICAPABILITIES == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1331;
            PAGEFLIP (  __context__ , (ushort)( 4 )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1335;
            PAGEFLIP (  __context__ , (ushort)( 4 )) ; 
            __context__.SourceCodeLine = 1336;
            GIBROWSINGMEDIA = (ushort) ( 1 ) ; 
            } 
        
        
        }
        
    private void DOCOMMAND (  SplusExecutionContext __context__, CrestronString CMD__DOLLAR__ ) 
        { 
        CrestronString NEWFILTER__DOLLAR__;
        NEWFILTER__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
        
        
        __context__.SourceCodeLine = 1346;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 1346;
            Print( "{0}\r\n", CMD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 1349;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FROM_IP_CLIENT_STATUS  .UshortValue == 2))  ) ) 
            { 
            __context__.SourceCodeLine = 1350;
            IP_TX__DOLLAR__  .UpdateValue ( CMD__DOLLAR__ + "\u000D\u000A"  ) ; 
            } 
        
        __context__.SourceCodeLine = 1355;
        GITICK = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1358;
        Functions.ProcessLogic ( ) ; 
        
        }
        
    private void PARSESTATECHANGE (  SplusExecutionContext __context__, CrestronString IN__DOLLAR__ ) 
        { 
        CrestronString SESSION__DOLLAR__;
        SESSION__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
        
        CrestronString PARM__DOLLAR__;
        PARM__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
        
        CrestronString VALUE__DOLLAR__;
        VALUE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1536, this );
        
        CrestronString CMD__DOLLAR__;
        CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
        
        CrestronString TYPE;
        TYPE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16, this );
        
        ushort T1 = 0;
        ushort T2 = 0;
        ushort T3 = 0;
        
        ushort G = 0;
        
        
        __context__.SourceCodeLine = 1372;
        T1 = (ushort) ( Functions.Find( " " , IN__DOLLAR__ ) ) ; 
        __context__.SourceCodeLine = 1373;
        T2 = (ushort) ( Functions.Find( " " , IN__DOLLAR__ , (T1 + 1) ) ) ; 
        __context__.SourceCodeLine = 1374;
        T3 = (ushort) ( Functions.Find( "=" , IN__DOLLAR__ , (T2 + 1) ) ) ; 
        __context__.SourceCodeLine = 1376;
        SESSION__DOLLAR__  .UpdateValue ( Functions.Left ( IN__DOLLAR__ ,  (int) ( (T1 - 1) ) )  ) ; 
        __context__.SourceCodeLine = 1377;
        PARM__DOLLAR__  .UpdateValue ( Functions.Mid ( IN__DOLLAR__ ,  (int) ( (T2 + 1) ) ,  (int) ( ((T3 - T2) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 1378;
        VALUE__DOLLAR__  .UpdateValue ( Functions.Right ( IN__DOLLAR__ ,  (int) ( (Functions.Length( IN__DOLLAR__ ) - T3) ) )  ) ; 
        __context__.SourceCodeLine = 1380;
        
            {
            int __SPLS_TMPVAR__SWTCH_6__ = ((int)1);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "Back")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1385;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUE__DOLLAR__ == "False"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1386;
                        GIBACKAVAILABLE = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 1387;
                        BACK_ENABLE  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1389;
                        GIBACKAVAILABLE = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 1390;
                        BACK_ENABLE  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 1393;
                    GISERVERHANDLESBACK = (ushort) ( 1 ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "BaseWebUrl")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1398;
                    GSARTSERVER  .UpdateValue ( VALUE__DOLLAR__  ) ; 
                    __context__.SourceCodeLine = 1401;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Right( GSARTSERVER , (int)( 4 ) ) == ":80/"))  ) ) 
                        {
                        __context__.SourceCodeLine = 1401;
                        GSARTSERVER  .UpdateValue ( Functions.Left ( GSARTSERVER ,  (int) ( (Functions.Length( GSARTSERVER ) - 4) ) ) + "/"  ) ; 
                        }
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "ContextMenu")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1404;
                    ACTIONS_ENABLED_FB  .Value = (ushort) ( STOB( __context__ , VALUE__DOLLAR__ ) ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "MediaArtChanged")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1406;
                    REFRESH_NOWPLAYING_ART (  __context__  ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "MediaControl")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1409;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_7__ = ((int)1);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "Stop")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1410;
                                CURRENT_PLAY_STATE  .Value = (ushort) ( 0 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "Play")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1411;
                                CURRENT_PLAY_STATE  .Value = (ushort) ( 1 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "Pause")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1412;
                                CURRENT_PLAY_STATE  .Value = (ushort) ( 2 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "FF1")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1413;
                                CURRENT_PLAY_STATE  .Value = (ushort) ( 3 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "FF2")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1414;
                                CURRENT_PLAY_STATE  .Value = (ushort) ( 3 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "FF3")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1415;
                                CURRENT_PLAY_STATE  .Value = (ushort) ( 3 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "Rewind1")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1416;
                                CURRENT_PLAY_STATE  .Value = (ushort) ( 4 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "Rewind2")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1417;
                                CURRENT_PLAY_STATE  .Value = (ushort) ( 4 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "Rewind3")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1418;
                                CURRENT_PLAY_STATE  .Value = (ushort) ( 4 ) ; 
                                }
                            
                            } 
                            
                        }
                        
                    
                    __context__.SourceCodeLine = 1421;
                    GETCONTEXTBUTTONSTATES (  __context__  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "MetaData1")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1424;
                    METADATA1__DOLLAR__  .UpdateValue ( VALUE__DOLLAR__  ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "MetaData2")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1425;
                    METADATA2__DOLLAR__  .UpdateValue ( VALUE__DOLLAR__  ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "MetaData3")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1426;
                    METADATA3__DOLLAR__  .UpdateValue ( VALUE__DOLLAR__  ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "MetaData4")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1427;
                    METADATA4__DOLLAR__  .UpdateValue ( VALUE__DOLLAR__  ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "MetaLabel1")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1429;
                    METALABEL1__DOLLAR__  .UpdateValue ( VALUE__DOLLAR__  ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "MetaLabel2")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1430;
                    METALABEL2__DOLLAR__  .UpdateValue ( VALUE__DOLLAR__  ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "MetaLabel3")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1431;
                    METALABEL3__DOLLAR__  .UpdateValue ( VALUE__DOLLAR__  ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "MetaLabel4")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1432;
                    METALABEL4__DOLLAR__  .UpdateValue ( VALUE__DOLLAR__  ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "Mute")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1434;
                    MUTE_FB  .Value = (ushort) ( Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "NowPlayingType")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1438;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_8__ = ((int)1);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "Music")) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 1442;
                                CURRENT_MEDIA_TYPE  .Value = (ushort) ( 1 ) ; 
                                __context__.SourceCodeLine = 1443;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CONFIGURAITON_FB  .Value == 0))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 1443;
                                    DOCOMMAND (  __context__ , "navigate nowplaying") ; 
                                    }
                                
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "Movie")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1445;
                                CURRENT_MEDIA_TYPE  .Value = (ushort) ( 2 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "Dvr")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1446;
                                CURRENT_MEDIA_TYPE  .Value = (ushort) ( 3 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "Pictures")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1447;
                                CURRENT_MEDIA_TYPE  .Value = (ushort) ( 5 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "Video")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1448;
                                CURRENT_MEDIA_TYPE  .Value = (ushort) ( 4 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "LiveTv")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1449;
                                CURRENT_MEDIA_TYPE  .Value = (ushort) ( 8 ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1450;
                                CURRENT_MEDIA_TYPE  .Value = (ushort) ( 8 ) ; 
                                }
                            
                            } 
                            
                        }
                        
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "NowPlayingGuid")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1456;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( VALUE__DOLLAR__ , (int)( 1 ) ) == "{"))  ) ) 
                        {
                        __context__.SourceCodeLine = 1456;
                        VALUE__DOLLAR__  .UpdateValue ( Functions.Mid ( VALUE__DOLLAR__ ,  (int) ( 2 ) ,  (int) ( (Functions.Length( VALUE__DOLLAR__ ) - 2) ) )  ) ; 
                        }
                    
                    __context__.SourceCodeLine = 1457;
                    GSNOWPLAYINGGUID  .UpdateValue ( VALUE__DOLLAR__  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "NowPlayingSrce")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1462;
                    GSNOWPLAYINGSOURCE  .UpdateValue ( VALUE__DOLLAR__  ) ; 
                    __context__.SourceCodeLine = 1465;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_9__ = ((int)1);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "LastFM")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1467;
                                SERVICE_LOGO_FB  .Value = (ushort) ( 1 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "Pandora")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1468;
                                SERVICE_LOGO_FB  .Value = (ushort) ( 2 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "Sirius")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1469;
                                SERVICE_LOGO_FB  .Value = (ushort) ( 3 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "Rhapsody")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1470;
                                SERVICE_LOGO_FB  .Value = (ushort) ( 4 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "Spotify")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1471;
                                SERVICE_LOGO_FB  .Value = (ushort) ( 5 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( Functions.BoolToInt (VALUE__DOLLAR__ == "RadioTime")) ) ) ) 
                                {
                                __context__.SourceCodeLine = 1472;
                                SERVICE_LOGO_FB  .Value = (ushort) ( 6 ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1473;
                                SERVICE_LOGO_FB  .Value = (ushort) ( 0 ) ; 
                                }
                            
                            } 
                            
                        }
                        
                    
                    __context__.SourceCodeLine = 1477;
                    THUMBSUP_ENABLED_FB  .Value = (ushort) ( ((GITHUMBSUP + 1) + ((3 * Functions.BoolToInt (GSNOWPLAYINGSOURCE == "LastFM")) + (6 * Functions.BoolToInt (GSNOWPLAYINGSOURCE == "Rhapsody")))) ) ; 
                    __context__.SourceCodeLine = 1478;
                    THUMBSDOWN_ENABLED_FB  .Value = (ushort) ( ((GITHUMBSDOWN + 1) + ((3 * Functions.BoolToInt (GSNOWPLAYINGSOURCE == "LastFM")) + (6 * Functions.BoolToInt (GSNOWPLAYINGSOURCE == "Rhapsody")))) ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "Recording")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1481;
                    RECORD_FB  .Value = (ushort) ( Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "Repeat")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1485;
                    GIREPEATSTATE = (ushort) ( Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) ) ; 
                    __context__.SourceCodeLine = 1486;
                    if ( Functions.TestForTrue  ( ( GIREPEATAVAILABLE)  ) ) 
                        {
                        __context__.SourceCodeLine = 1486;
                        REPEAT_FB  .Value = (ushort) ( GIREPEATSTATE ) ; 
                        }
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "RepeatAvailable")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1491;
                    GIREPEATAVAILABLE = (ushort) ( Functions.BoolToInt (Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) == 1) ) ; 
                    __context__.SourceCodeLine = 1492;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GIREPEATAVAILABLE == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1495;
                        REPEAT_FB  .Value = (ushort) ( GIREPEATSTATE ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1499;
                        REPEAT_FB  .Value = (ushort) ( 2 ) ; 
                        } 
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "Scrobbling")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1506;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUE__DOLLAR__ == "-1"))  ) ) 
                        {
                        __context__.SourceCodeLine = 1506;
                        SCROBBLE_FB  .Value = (ushort) ( 0 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1506;
                        SCROBBLE_FB  .Value = (ushort) ( (Functions.Atoi( VALUE__DOLLAR__ ) + 1) ) ; 
                        }
                    
                    __context__.SourceCodeLine = 1508;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUE__DOLLAR__ == "1"))  ) ) 
                        { 
                        } 
                    
                    else 
                        { 
                        } 
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "Shuffle")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1520;
                    GISHUFFLESTATE = (ushort) ( Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) ) ; 
                    __context__.SourceCodeLine = 1521;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GISHUFFLEAVAILABLE == 1))  ) ) 
                        {
                        __context__.SourceCodeLine = 1521;
                        SHUFFLE_FB  .Value = (ushort) ( GISHUFFLESTATE ) ; 
                        }
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "ShuffleAvailable")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1526;
                    GISHUFFLEAVAILABLE = (ushort) ( Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) ) ; 
                    __context__.SourceCodeLine = 1527;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GISHUFFLEAVAILABLE == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1529;
                        SHUFFLE_FB  .Value = (ushort) ( GISHUFFLESTATE ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1533;
                        SHUFFLE_FB  .Value = (ushort) ( 2 ) ; 
                        } 
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "SeekAvailable")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1539;
                    GISEEKAVAILABLE = (ushort) ( Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "SupportsMusic")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1542;
                    SUPPORTSMUSIC = (ushort) ( Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "SupportsVideos")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1543;
                    SUPPORTSVIDEO = (ushort) ( Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "SupportsLiveTv")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1544;
                    SUPPORTSLIVETV = (ushort) ( Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "SupportsRecordedTv")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1545;
                    SUPPORTSRECORDEDTV = (ushort) ( Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "SupportsEpg")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1546;
                    SUPPORTSEPG = (ushort) ( Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "SupportsMovies")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1547;
                    SUPPORTSMOVIES = (ushort) ( Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "SupportsPictures")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1548;
                    SUPPORTSPICTURES = (ushort) ( Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "SupportsRadio")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1549;
                    SUPPORTSRADIO = (ushort) ( Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "SupportsVolumeUpDown")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1550;
                    SUPPORTSVOLUME = (ushort) ( Functions.Abs( STOB( __context__ , VALUE__DOLLAR__ ) ) ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "SupportsStatus")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1551;
                    UPDATEUICAPIBILITIES (  __context__  ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "Stars")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1556;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUE__DOLLAR__ == "-1"))  ) ) 
                        {
                        __context__.SourceCodeLine = 1556;
                        STARS_FB  .Value = (ushort) ( 0 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1556;
                        STARS_FB  .Value = (ushort) ( (Functions.Atoi( VALUE__DOLLAR__ ) + 1) ) ; 
                        }
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "ThumbsDown")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1561;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUE__DOLLAR__ != "-1"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1563;
                        GITHUMBSDOWN = (ushort) ( Functions.Atoi( VALUE__DOLLAR__ ) ) ; 
                        __context__.SourceCodeLine = 1564;
                        THUMBSDOWN_ENABLED_FB  .Value = (ushort) ( ((GITHUMBSDOWN + 1) + ((3 * Functions.BoolToInt (GSNOWPLAYINGSOURCE == "LastFM")) + (6 * Functions.BoolToInt (GSNOWPLAYINGSOURCE == "Rhapsody")))) ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1568;
                        GITHUMBSDOWN = (ushort) ( Functions.ToInteger( -( 1 ) ) ) ; 
                        __context__.SourceCodeLine = 1569;
                        THUMBSDOWN_ENABLED_FB  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "ThumbsUp")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1575;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUE__DOLLAR__ != "-1"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1577;
                        GITHUMBSUP = (ushort) ( Functions.Atoi( VALUE__DOLLAR__ ) ) ; 
                        __context__.SourceCodeLine = 1578;
                        THUMBSUP_ENABLED_FB  .Value = (ushort) ( ((GITHUMBSUP + 1) + ((3 * Functions.BoolToInt (GSNOWPLAYINGSOURCE == "LastFM")) + (6 * Functions.BoolToInt (GSNOWPLAYINGSOURCE == "Rhapsody")))) ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1582;
                        GITHUMBSUP = (ushort) ( Functions.ToInteger( -( 1 ) ) ) ; 
                        __context__.SourceCodeLine = 1583;
                        THUMBSUP_ENABLED_FB  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "TotalTracks")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1589;
                    GITOTALTRACKS = (ushort) ( Functions.Atoi( VALUE__DOLLAR__ ) ) ; 
                    __context__.SourceCodeLine = 1590;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GBJUMP == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1592;
                        CMD__DOLLAR__  .UpdateValue ( "JumpToNowPlayingItem " + Functions.ItoA (  (int) ( GITOTALTRACKS ) )  ) ; 
                        __context__.SourceCodeLine = 1593;
                        DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
                        __context__.SourceCodeLine = 1594;
                        DOCOMMAND (  __context__ , "Mute False") ; 
                        __context__.SourceCodeLine = 1595;
                        GBJUMP = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "TrackDuration")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1599;
                    SETTRACKLEN (  __context__ , VALUE__DOLLAR__) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "TrackTime")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1601;
                    SETTRACKTIME (  __context__ , VALUE__DOLLAR__) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "TrackNumber")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1606;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Atoi( VALUE__DOLLAR__ ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1608;
                        PLAYING_TRACK_NUMBER  .UpdateValue ( VALUE__DOLLAR__  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1612;
                        PLAYING_TRACK_NUMBER  .UpdateValue ( ""  ) ; 
                        } 
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "Volume")) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1616;
                    VOLUME_FB  .Value = (ushort) ( Functions.Atoi( VALUE__DOLLAR__ ) ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( Functions.BoolToInt (PARM__DOLLAR__ == "UI")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1620;
                    TYPE  .UpdateValue ( Functions.Remove ( " " , VALUE__DOLLAR__ , 1)  ) ; 
                    __context__.SourceCodeLine = 1622;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == "Clear "))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1624;
                        CLEARDIALOGS (  __context__  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1627;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == "InputBox "))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1629;
                            GETKBINPUTUI (  __context__ , VALUE__DOLLAR__) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1632;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == "MessageBox "))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1634;
                                SHOWMESSAGEBOX (  __context__ , VALUE__DOLLAR__) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1637;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == "Navigate "))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1639;
                                    CLEARDIALOGS (  __context__  ) ; 
                                    __context__.SourceCodeLine = 1640;
                                    PAGEFLIP (  __context__ , (ushort)( 4 )) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1643;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == "StatusMessage "))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1645;
                                        MESSAGECAPTION__DOLLAR__  .UpdateValue ( GSFILTERSDESC  ) ; 
                                        __context__.SourceCodeLine = 1646;
                                        MESSAGETEXT__DOLLAR__  .UpdateValue ( Functions.Mid ( VALUE__DOLLAR__ ,  (int) ( 2 ) ,  (int) ( (Functions.Length( VALUE__DOLLAR__ ) - 2) ) )  ) ; 
                                        __context__.SourceCodeLine = 1647;
                                        DIALOG_BUTTONS  .Value = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 1648;
                                        DIALOG_ENABLED_FB  .Value = (ushort) ( 1 ) ; 
                                        __context__.SourceCodeLine = 1650;
                                        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_0__" , 500 , __SPLS_TMPVAR__WAITLABEL_0___Callback ) ;
                                        } 
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    } 
                
                } 
                
            }
            
        
        
        }
        
    public void __SPLS_TMPVAR__WAITLABEL_0___CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            
            __context__.SourceCodeLine = 1652;
            CLEARDIALOGS (  __context__  ) ; 
            
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    
private void SETFILTERDESCRIPTION (  SplusExecutionContext __context__, CrestronString DATUM ) 
    { 
    ushort POS = 0;
    
    
    __context__.SourceCodeLine = 1663;
    POS = (ushort) ( Functions.Find( "Ok" , DATUM ) ) ; 
    __context__.SourceCodeLine = 1664;
    GSFILTERSDESC  .UpdateValue ( Functions.Mid ( DATUM ,  (int) ( (POS + 4) ) ,  (int) ( (Functions.Length( DATUM ) - (POS + 4)) ) )  ) ; 
    
    }
    
private void PARSETOKEN (  SplusExecutionContext __context__, CrestronString IN__DOLLAR__ ) 
    { 
    ushort I = 0;
    
    
    __context__.SourceCodeLine = 1673;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\r\n" , IN__DOLLAR__ ) > 0 ))  ) ) 
        {
        __context__.SourceCodeLine = 1673;
        IN__DOLLAR__  .UpdateValue ( Functions.Left ( IN__DOLLAR__ ,  (int) ( (Functions.Find( "\r\n" , IN__DOLLAR__ ) - 1) ) )  ) ; 
        }
    
    __context__.SourceCodeLine = 1675;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
        {
        __context__.SourceCodeLine = 1675;
        Print( "  {0}\r\n", IN__DOLLAR__ ) ; 
        }
    
    __context__.SourceCodeLine = 1677;
    
        {
        int __SPLS_TMPVAR__SWTCH_10__ = ((int)1);
        
            { 
            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( Functions.BoolToInt (Functions.Left( IN__DOLLAR__ , (int)( 12 ) ) == "TestEncoding")) ) ) ) 
                { 
                __context__.SourceCodeLine = 1680;
                CAPTION  .UpdateValue ( IN__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 1681;
                Functions.Delay (  (int) ( 100 ) ) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == (  (int) ( Functions.BoolToInt (Functions.Left( IN__DOLLAR__ , (int)( 2 ) ) == "  ") ) ) ) ) ) 
                { 
                __context__.SourceCodeLine = 1686;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GBFETCHINGLIST == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 1686;
                    PROCESSLISTITEM (  __context__ , IN__DOLLAR__) ; 
                    }
                
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( Functions.BoolToInt (Functions.Left( IN__DOLLAR__ , (int)( 5 ) ) == "Begin")) ) ) ) 
                { 
                __context__.SourceCodeLine = 1691;
                PROCESSNEWLIST (  __context__ , IN__DOLLAR__) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( Functions.BoolToInt (Functions.Left( IN__DOLLAR__ , (int)( 3 ) ) == "End")) ) ) ) 
                { 
                __context__.SourceCodeLine = 1696;
                GIMOREITEMS = (ushort) ( Functions.BoolToInt ( Functions.Find( " More" , IN__DOLLAR__ ) > 0 ) ) ; 
                __context__.SourceCodeLine = 1697;
                PROCESSLISTEND (  __context__  ) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( Functions.BoolToInt (Functions.Left( IN__DOLLAR__ , (int)( 13 ) ) == "MovieProperty")) ) ) ) 
                { 
                __context__.SourceCodeLine = 1702;
                PROCESSMOVIEPROPERTY (  __context__ , IN__DOLLAR__) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( IN__DOLLAR__ , (int)( 4 ) ) == "Push") ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "Filter" , IN__DOLLAR__ ) > 0 ) )) )) ) ) ) 
                { 
                __context__.SourceCodeLine = 1707;
                SETFILTERDESCRIPTION (  __context__ , IN__DOLLAR__) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( (Functions.BoolToInt ( Functions.Find( "StateChanged " , IN__DOLLAR__ ) > 0 ) | Functions.BoolToInt ( Functions.Find( "ReportState " , IN__DOLLAR__ ) > 0 ))) ) ) ) 
                { 
                __context__.SourceCodeLine = 1712;
                PARSESTATECHANGE (  __context__ , IN__DOLLAR__) ; 
                } 
            
            } 
            
        }
        
    
    
    }
    
private void SETFILTERCONTEXT (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 1718;
    GSFILTERCONTEXT [ 1 ]  .UpdateValue ( "Music"  ) ; 
    __context__.SourceCodeLine = 1719;
    GSFILTERCONTEXT [ 2 ]  .UpdateValue ( "Movie"  ) ; 
    __context__.SourceCodeLine = 1720;
    GSFILTERCONTEXT [ 3 ]  .UpdateValue ( "Dvr"  ) ; 
    __context__.SourceCodeLine = 1721;
    GSFILTERCONTEXT [ 4 ]  .UpdateValue ( "Video"  ) ; 
    __context__.SourceCodeLine = 1722;
    GSFILTERCONTEXT [ 5 ]  .UpdateValue ( "Picture"  ) ; 
    __context__.SourceCodeLine = 1723;
    GSFILTERCONTEXT [ 6 ]  .UpdateValue ( "Radio"  ) ; 
    
    }
    
private void SETFILTER (  SplusExecutionContext __context__, ushort CONTEXT , CrestronString FILTER , ushort APPEND ) 
    { 
    CrestronString CMD__DOLLAR__;
    CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    
    __context__.SourceCodeLine = 1730;
    if ( Functions.TestForTrue  ( ( Functions.Not( APPEND ))  ) ) 
        { 
        __context__.SourceCodeLine = 1731;
        CMD__DOLLAR__  .UpdateValue ( "Set" + GSFILTERCONTEXT [ CONTEXT ] + "Filter Clear"  ) ; 
        __context__.SourceCodeLine = 1732;
        DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
        __context__.SourceCodeLine = 1733;
        GSFILTERS  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 1734;
        GSFILTERSDESC  .UpdateValue ( ""  ) ; 
        } 
    
    __context__.SourceCodeLine = 1737;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FILTER != ""))  ) ) 
        { 
        __context__.SourceCodeLine = 1738;
        CMD__DOLLAR__  .UpdateValue ( "Push" + GSFILTERCONTEXT [ CONTEXT ] + "Filter " + FILTER  ) ; 
        __context__.SourceCodeLine = 1739;
        DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
        __context__.SourceCodeLine = 1740;
        GSFILTERS  .UpdateValue ( GSFILTERS + FILTER + " "  ) ; 
        __context__.SourceCodeLine = 1741;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 1741;
            Print( "Filters are: {0}\r\n", GSFILTERS ) ; 
            }
        
        } 
    
    
    }
    
private void SETMEDIAMODE (  SplusExecutionContext __context__, ushort IMODE ) 
    { 
    
    __context__.SourceCodeLine = 1748;
    SETFILTER (  __context__ , (ushort)( IMODE ), "", (ushort)( 0 )) ; 
    __context__.SourceCodeLine = 1749;
    GIBROWSINGMEDIA = (ushort) ( IMODE ) ; 
    __context__.SourceCodeLine = 1750;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
        {
        __context__.SourceCodeLine = 1750;
        Print( "Browse Context={0}", GSFILTERCONTEXT [ GIBROWSINGMEDIA ] ) ; 
        }
    
    __context__.SourceCodeLine = 1753;
    
        {
        int __SPLS_TMPVAR__SWTCH_11__ = ((int)IMODE);
        
            { 
            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_11__ == ( 1) ) ) ) 
                { 
                __context__.SourceCodeLine = 1755;
                CAPTION  .UpdateValue ( "Music"  ) ; 
                __context__.SourceCodeLine = 1755;
                GSFILTERSDESC  .UpdateValue ( "Music"  ) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_11__ == ( 2) ) ) ) 
                { 
                __context__.SourceCodeLine = 1756;
                CAPTION  .UpdateValue ( "Movies"  ) ; 
                __context__.SourceCodeLine = 1756;
                GSFILTERSDESC  .UpdateValue ( "Movies"  ) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_11__ == ( 3) ) ) ) 
                { 
                __context__.SourceCodeLine = 1757;
                CAPTION  .UpdateValue ( "Recorded TV"  ) ; 
                __context__.SourceCodeLine = 1757;
                GSFILTERSDESC  .UpdateValue ( "Recorded TV"  ) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_11__ == ( 5) ) ) ) 
                { 
                __context__.SourceCodeLine = 1758;
                CAPTION  .UpdateValue ( "Pictures"  ) ; 
                __context__.SourceCodeLine = 1758;
                GSFILTERSDESC  .UpdateValue ( "Pictures"  ) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_11__ == ( 4) ) ) ) 
                { 
                __context__.SourceCodeLine = 1759;
                CAPTION  .UpdateValue ( "Videos"  ) ; 
                __context__.SourceCodeLine = 1759;
                GSFILTERSDESC  .UpdateValue ( "Videos"  ) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_11__ == ( 7) ) ) ) 
                { 
                __context__.SourceCodeLine = 1760;
                CAPTION  .UpdateValue ( "Live TV"  ) ; 
                __context__.SourceCodeLine = 1760;
                GSFILTERSDESC  .UpdateValue ( "Live TV"  ) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_11__ == ( 6) ) ) ) 
                { 
                __context__.SourceCodeLine = 1761;
                CAPTION  .UpdateValue ( "Radio"  ) ; 
                __context__.SourceCodeLine = 1761;
                GSFILTERSDESC  .UpdateValue ( "Radio"  ) ; 
                } 
            
            } 
            
        }
        
    
    
    }
    
private void APPLYFILTERS (  SplusExecutionContext __context__, CrestronString REFFILTERS__DOLLAR__ ) 
    { 
    CrestronString FILTERS__DOLLAR__;
    FILTERS__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
    
    CrestronString FILTER__DOLLAR__;
    FILTER__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    CrestronString CMD__DOLLAR__;
    CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    
    __context__.SourceCodeLine = 1773;
    CMD__DOLLAR__  .UpdateValue ( "Set" + GSFILTERCONTEXT [ GIBROWSINGMEDIA ] + "Filter Clear"  ) ; 
    __context__.SourceCodeLine = 1774;
    DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
    __context__.SourceCodeLine = 1776;
    GSFILTERS  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 1777;
    FILTERS__DOLLAR__  .UpdateValue ( REFFILTERS__DOLLAR__  ) ; 
    __context__.SourceCodeLine = 1779;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
        {
        __context__.SourceCodeLine = 1779;
        Print( "Applying Filters : {0}\r\n", FILTERS__DOLLAR__ ) ; 
        }
    
    __context__.SourceCodeLine = 1781;
    do 
        { 
        __context__.SourceCodeLine = 1784;
        FILTER__DOLLAR__  .UpdateValue ( GETFIELD (  __context__ , FILTERS__DOLLAR__)  ) ; 
        __context__.SourceCodeLine = 1785;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FILTER__DOLLAR__ != ""))  ) ) 
            { 
            __context__.SourceCodeLine = 1787;
            CMD__DOLLAR__  .UpdateValue ( "Push" + GSFILTERCONTEXT [ GIBROWSINGMEDIA ] + "Filter " + FILTER__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 1788;
            DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
            } 
        
        } 
    while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (FILTER__DOLLAR__ == "")) )); 
    
    }
    
private void ADDTOHISTORY (  SplusExecutionContext __context__, CrestronString CMD__DOLLAR__ , CrestronString FILTERS__DOLLAR__ ) 
    { 
    ushort I = 0;
    
    CrestronString CMD1__DOLLAR__;
    CMD1__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    
    CrestronString CMD2__DOLLAR__;
    CMD2__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    
    
    __context__.SourceCodeLine = 1800;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GISERVERHANDLESBACK == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 1802;
        CMD1__DOLLAR__  .UpdateValue ( CMD__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 1803;
        CMD2__DOLLAR__  .UpdateValue ( HISTORY [ 0] . COMMAND  ) ; 
        __context__.SourceCodeLine = 1805;
        CMD1__DOLLAR__  .UpdateValue ( Functions.Left ( CMD1__DOLLAR__ ,  (int) ( Functions.Find( " " , CMD1__DOLLAR__ ) ) )  ) ; 
        __context__.SourceCodeLine = 1806;
        CMD2__DOLLAR__  .UpdateValue ( Functions.Left ( CMD2__DOLLAR__ ,  (int) ( Functions.Find( " " , CMD2__DOLLAR__ ) ) )  ) ; 
        __context__.SourceCodeLine = 1808;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD1__DOLLAR__ == CMD2__DOLLAR__))  ) ) 
            { 
            __context__.SourceCodeLine = 1810;
            HISTORY [ 0] . COMMAND  .UpdateValue ( CMD__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 1811;
            HISTORY [ 0] . FILTERS  .UpdateValue ( FILTERS__DOLLAR__  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1816;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 5 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)1; 
            int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 1818;
                HISTORY [ I] . COMMAND  .UpdateValue ( HISTORY [ (I - 1)] . COMMAND  ) ; 
                __context__.SourceCodeLine = 1819;
                HISTORY [ I] . FILTERS  .UpdateValue ( HISTORY [ (I - 1)] . FILTERS  ) ; 
                __context__.SourceCodeLine = 1820;
                HISTORY [ I] . CONTEXT = (ushort) ( HISTORY[ (I - 1) ].CONTEXT ) ; 
                __context__.SourceCodeLine = 1821;
                HISTORY [ I] . PAGE = (ushort) ( HISTORY[ (I - 1) ].PAGE ) ; 
                __context__.SourceCodeLine = 1822;
                HISTORY [ I] . DESCRIPTION  .UpdateValue ( HISTORY [ (I - 1)] . DESCRIPTION  ) ; 
                __context__.SourceCodeLine = 1816;
                } 
            
            __context__.SourceCodeLine = 1825;
            HISTORY [ 0] . COMMAND  .UpdateValue ( CMD__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 1826;
            HISTORY [ 0] . FILTERS  .UpdateValue ( FILTERS__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 1827;
            HISTORY [ 0] . CONTEXT = (ushort) ( GIBROWSINGMEDIA ) ; 
            __context__.SourceCodeLine = 1828;
            HISTORY [ 0] . PAGE = (ushort) ( GICURRENTPAGE ) ; 
            __context__.SourceCodeLine = 1829;
            HISTORY [ 0] . DESCRIPTION  .UpdateValue ( GSFILTERSDESC  ) ; 
            } 
        
        __context__.SourceCodeLine = 1832;
        BACK_ENABLE  .Value = (ushort) ( Functions.BoolToInt (HISTORY[ 1 ].COMMAND != "") ) ; 
        __context__.SourceCodeLine = 1834;
        SHOWHISTORY (  __context__  ) ; 
        } 
    
    
    }
    
private void RECALLHISTORY (  SplusExecutionContext __context__ ) 
    { 
    ushort I = 0;
    ushort D = 0;
    
    ushort T1 = 0;
    ushort T2 = 0;
    
    CrestronString LISTSTART__DOLLAR__;
    LISTSTART__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    
    
    __context__.SourceCodeLine = 1844;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GISERVERHANDLESBACK == 1))  ) ) 
        { 
        __context__.SourceCodeLine = 1846;
        Trace( "server handles back") ; 
        __context__.SourceCodeLine = 1848;
        CLEARLIST (  __context__  ) ; 
        __context__.SourceCodeLine = 1849;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GICURRENTPAGE == 4))  ) ) 
            { 
            __context__.SourceCodeLine = 1850;
            Trace( "sending back 0") ; 
            __context__.SourceCodeLine = 1851;
            DOCOMMAND (  __context__ , "Back 0") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1855;
            Trace( "sending back 1") ; 
            __context__.SourceCodeLine = 1856;
            DOCOMMAND (  __context__ , "Back 1") ; 
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 1862;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (GICURRENTPAGE == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (GICURRENTPAGE == 4) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 1862;
            D = (ushort) ( 0 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1862;
            D = (ushort) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 1864;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HISTORY[ D ].COMMAND != ""))  ) ) 
            { 
            __context__.SourceCodeLine = 1867;
            CLEARLIST (  __context__  ) ; 
            __context__.SourceCodeLine = 1870;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "Browse" , HISTORY[ 1 ].COMMAND ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1872;
                T1 = (ushort) ( Functions.Find( " " , HISTORY[ D ].COMMAND ) ) ; 
                __context__.SourceCodeLine = 1873;
                T2 = (ushort) ( Functions.Find( " " , HISTORY[ D ].COMMAND , (T1 + 1) ) ) ; 
                __context__.SourceCodeLine = 1874;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( T1 > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( T2 > 0 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1876;
                    GILISTSTARTPOS = (ushort) ( Functions.Atoi( Functions.Mid( HISTORY[ D ].COMMAND , (int)( (T1 + 1) ) , (int)( ((T2 - T1) - 1) ) ) ) ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 1880;
            GIBROWSINGMEDIA = (ushort) ( HISTORY[ D ].CONTEXT ) ; 
            __context__.SourceCodeLine = 1881;
            APPLYFILTERS (  __context__ , HISTORY[ D ].FILTERS) ; 
            __context__.SourceCodeLine = 1882;
            GSFILTERSDESC  .UpdateValue ( HISTORY [ D] . DESCRIPTION  ) ; 
            __context__.SourceCodeLine = 1883;
            PAGEFLIP (  __context__ , (ushort)( HISTORY[ D ].PAGE )) ; 
            __context__.SourceCodeLine = 1884;
            DOCOMMAND (  __context__ , HISTORY[ D ].COMMAND) ; 
            } 
        
        __context__.SourceCodeLine = 1887;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (D == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 1889;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)4; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 1891;
                HISTORY [ I] . COMMAND  .UpdateValue ( HISTORY [ (I + 1)] . COMMAND  ) ; 
                __context__.SourceCodeLine = 1892;
                HISTORY [ I] . FILTERS  .UpdateValue ( HISTORY [ (I + 1)] . FILTERS  ) ; 
                __context__.SourceCodeLine = 1893;
                HISTORY [ I] . DESCRIPTION  .UpdateValue ( HISTORY [ (I + 1)] . DESCRIPTION  ) ; 
                __context__.SourceCodeLine = 1894;
                HISTORY [ I] . CONTEXT = (ushort) ( HISTORY[ (I + 1) ].CONTEXT ) ; 
                __context__.SourceCodeLine = 1895;
                HISTORY [ I] . PAGE = (ushort) ( HISTORY[ (I + 1) ].PAGE ) ; 
                __context__.SourceCodeLine = 1889;
                } 
            
            __context__.SourceCodeLine = 1898;
            HISTORY [ 5] . COMMAND  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1899;
            HISTORY [ 5] . FILTERS  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1900;
            HISTORY [ 5] . DESCRIPTION  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1901;
            HISTORY [ 5] . CONTEXT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1902;
            HISTORY [ 5] . PAGE = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 1905;
        BACK_ENABLE  .Value = (ushort) ( Functions.BoolToInt (HISTORY[ 1 ].COMMAND != "") ) ; 
        __context__.SourceCodeLine = 1906;
        SHOWHISTORY (  __context__  ) ; 
        } 
    
    
    }
    
private void BROWSELIST (  SplusExecutionContext __context__, CrestronString SLIST , ushort START , ushort COUNT , ushort HISTORY ) 
    { 
    CrestronString CMD__DOLLAR__;
    CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    
    
    __context__.SourceCodeLine = 1914;
    GIPAGINGVALUE = (ushort) ( COUNT ) ; 
    __context__.SourceCodeLine = 1915;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( START < 1 ))  ) ) 
        {
        __context__.SourceCodeLine = 1915;
        START = (ushort) ( 1 ) ; 
        }
    
    __context__.SourceCodeLine = 1916;
    GILISTSTARTPOS = (ushort) ( START ) ; 
    __context__.SourceCodeLine = 1919;
    LIST_POSITION  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 1921;
    CLEARLIST (  __context__  ) ; 
    __context__.SourceCodeLine = 1923;
    CMD__DOLLAR__  .UpdateValue ( "Browse" + SLIST + " " + Functions.ItoA (  (int) ( START ) ) + " " + Functions.ItoA (  (int) ( COUNT ) )  ) ; 
    __context__.SourceCodeLine = 1924;
    DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
    __context__.SourceCodeLine = 1926;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
        {
        __context__.SourceCodeLine = 1926;
        Print( "Start = {0:d}\u000D", (ushort)START) ; 
        }
    
    __context__.SourceCodeLine = 1928;
    PREV_ENABLE  .Value = (ushort) ( Functions.BoolToInt ( START > 1 ) ) ; 
    __context__.SourceCodeLine = 1929;
    SCROLL_ENABLE  .Value = (ushort) ( Functions.BoolToInt ( (Functions.TestForTrue ( NEXT_ENABLE  .Value ) || Functions.TestForTrue ( PREV_ENABLE  .Value )) ) ) ; 
    __context__.SourceCodeLine = 1930;
    ADDTOHISTORY (  __context__ , CMD__DOLLAR__, GSFILTERS) ; 
    
    }
    
private void BROWSEFILTERS (  SplusExecutionContext __context__, CrestronString MEDIA__DOLLAR__ ) 
    { 
    
    __context__.SourceCodeLine = 1936;
    LIST_POSITION  .UpdateValue ( ""  ) ; 
    __context__.SourceCodeLine = 1937;
    CLEARLIST (  __context__  ) ; 
    __context__.SourceCodeLine = 1938;
    GISEARCH = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 1940;
    
        {
        int __SPLS_TMPVAR__SWTCH_12__ = ((int)1);
        
            { 
            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( Functions.BoolToInt (MEDIA__DOLLAR__ == "Music")) ) ) ) 
                { 
                __context__.SourceCodeLine = 1943;
                PARSETOKEN (  __context__ , "BeginMusicFilters Total=6") ; 
                __context__.SourceCodeLine = 1944;
                PARSETOKEN (  __context__ , "  MusicFilter 0 Albums") ; 
                __context__.SourceCodeLine = 1945;
                PARSETOKEN (  __context__ , "  MusicFilter 0 Artists") ; 
                __context__.SourceCodeLine = 1946;
                PARSETOKEN (  __context__ , "  MusicFilter 0 Genres") ; 
                __context__.SourceCodeLine = 1947;
                PARSETOKEN (  __context__ , "  MusicFilter 0 Playlists") ; 
                __context__.SourceCodeLine = 1948;
                PARSETOKEN (  __context__ , "  MusicFilter 0 Radio") ; 
                __context__.SourceCodeLine = 1949;
                PARSETOKEN (  __context__ , "  MusicFilter 0 Titles") ; 
                __context__.SourceCodeLine = 1950;
                PARSETOKEN (  __context__ , "EndMusicFilters NoMore") ; 
                __context__.SourceCodeLine = 1951;
                SETMEDIAMODE (  __context__ , (ushort)( 1 )) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( Functions.BoolToInt (MEDIA__DOLLAR__ == "Movies")) ) ) ) 
                { 
                __context__.SourceCodeLine = 1955;
                PARSETOKEN (  __context__ , "BeginMovieFilters Total=5") ; 
                __context__.SourceCodeLine = 1956;
                PARSETOKEN (  __context__ , "  MovieFilter 0 Titles") ; 
                __context__.SourceCodeLine = 1957;
                PARSETOKEN (  __context__ , "  MovieFilter 0 Genres") ; 
                __context__.SourceCodeLine = 1958;
                PARSETOKEN (  __context__ , "  MovieFilter 0 People") ; 
                __context__.SourceCodeLine = 1959;
                PARSETOKEN (  __context__ , "  MovieFilter 0 Ratings") ; 
                __context__.SourceCodeLine = 1960;
                PARSETOKEN (  __context__ , "  MovieFilter 0 Years") ; 
                __context__.SourceCodeLine = 1961;
                PARSETOKEN (  __context__ , "EndMovieFilters NoMore") ; 
                __context__.SourceCodeLine = 1962;
                SETMEDIAMODE (  __context__ , (ushort)( 2 )) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( Functions.BoolToInt (MEDIA__DOLLAR__ == "RecordedTV")) ) ) ) 
                { 
                __context__.SourceCodeLine = 1966;
                PARSETOKEN (  __context__ , "BeginDVRFilters Total=5") ; 
                __context__.SourceCodeLine = 1967;
                PARSETOKEN (  __context__ , "  DVRFilter 0 Titles") ; 
                __context__.SourceCodeLine = 1968;
                PARSETOKEN (  __context__ , "  DVRFilter 0 Genres") ; 
                __context__.SourceCodeLine = 1969;
                PARSETOKEN (  __context__ , "  DVRFilter 0 Ratings") ; 
                __context__.SourceCodeLine = 1970;
                PARSETOKEN (  __context__ , "  DVRFilter 0 Recorded Date") ; 
                __context__.SourceCodeLine = 1971;
                PARSETOKEN (  __context__ , "  DVRFilter 0 Stations") ; 
                __context__.SourceCodeLine = 1972;
                PARSETOKEN (  __context__ , "EndDVRFilters NoMore") ; 
                __context__.SourceCodeLine = 1973;
                SETMEDIAMODE (  __context__ , (ushort)( 3 )) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( Functions.BoolToInt (MEDIA__DOLLAR__ == "Pictures")) ) ) ) 
                { 
                __context__.SourceCodeLine = 1978;
                SETMEDIAMODE (  __context__ , (ushort)( 5 )) ; 
                __context__.SourceCodeLine = 1979;
                BROWSELIST (  __context__ , "Pictures", (ushort)( 1 ), (ushort)( GIMAXLISTITEMS ), (ushort)( 1 )) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( Functions.BoolToInt (MEDIA__DOLLAR__ == "Videos")) ) ) ) 
                { 
                __context__.SourceCodeLine = 1984;
                SETMEDIAMODE (  __context__ , (ushort)( 4 )) ; 
                __context__.SourceCodeLine = 1985;
                BROWSELIST (  __context__ , "Videos", (ushort)( 1 ), (ushort)( GIMAXLISTITEMS ), (ushort)( 1 )) ; 
                } 
            
            } 
            
        }
        
    
    
    }
    
private void PLAYITEM (  SplusExecutionContext __context__, CrestronString TYPE , CrestronString ITEM , ushort JUMPTO ) 
    { 
    CrestronString CMD__DOLLAR__;
    CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 512, this );
    
    ushort IOLDTRACKCOUNT = 0;
    
    
    __context__.SourceCodeLine = 1995;
    IOLDTRACKCOUNT = (ushort) ( GITOTALTRACKS ) ; 
    __context__.SourceCodeLine = 1998;
    
        {
        int __SPLS_TMPVAR__SWTCH_13__ = ((int)1);
        
            { 
            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_13__ == ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (TYPE == "PictureFolder") ) || Functions.TestForTrue ( Functions.BoolToInt (TYPE == "PictureFile") )) )) ) ) ) 
                {
                __context__.SourceCodeLine = 2000;
                TYPE  .UpdateValue ( "SlideShow"  ) ; 
                }
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_13__ == ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (TYPE == "VideoFolder") ) || Functions.TestForTrue ( Functions.BoolToInt (TYPE == "VideoFile") )) )) ) ) ) 
                {
                __context__.SourceCodeLine = 2001;
                TYPE  .UpdateValue ( "Video"  ) ; 
                }
            
            } 
            
        }
        
    
    __context__.SourceCodeLine = 2005;
    CMD__DOLLAR__  .UpdateValue ( "Play" + TYPE + " " + ITEM  ) ; 
    __context__.SourceCodeLine = 2007;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (JUMPTO == 1) ) && Functions.TestForTrue ( Functions.BoolToInt ( IOLDTRACKCOUNT > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (GIBROWSINGMEDIA == 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (CURRENT_MEDIA_TYPE  .Value == 1) )) ))  ) ) 
        { 
        __context__.SourceCodeLine = 2009;
        CMD__DOLLAR__  .UpdateValue ( CMD__DOLLAR__ + " True"  ) ; 
        __context__.SourceCodeLine = 2011;
        GBJUMP = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 2013;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CURRENT_PLAY_STATE  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 2013;
            DOCOMMAND (  __context__ , "Mute True") ; 
            }
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 2018;
        GBJUMP = (ushort) ( 0 ) ; 
        } 
    
    __context__.SourceCodeLine = 2021;
    DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
    
    }
    
private void REMOVEITEM (  SplusExecutionContext __context__, CrestronString SGUID ) 
    { 
    CrestronString CMD__DOLLAR__;
    CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    
    __context__.SourceCodeLine = 2027;
    CMD__DOLLAR__  .UpdateValue ( "RemoveNowPlayingItem " + SGUID  ) ; 
    __context__.SourceCodeLine = 2028;
    DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
    __context__.SourceCodeLine = 2029;
    BROWSELIST (  __context__ , GSBROWSE, (ushort)( GILISTSTARTPOS ), (ushort)( GIMAXLISTITEMS ), (ushort)( 0 )) ; 
    
    }
    
private void REMOVEITEMBYINDEX (  SplusExecutionContext __context__, ushort INDEX ) 
    { 
    CrestronString CMD__DOLLAR__;
    CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
    
    ushort POSITION = 0;
    
    
    __context__.SourceCodeLine = 2036;
    POSITION = (ushort) ( ((GILISTSTARTPOS + INDEX) - 1) ) ; 
    __context__.SourceCodeLine = 2037;
    CMD__DOLLAR__  .UpdateValue ( "RemoveNowPlayingItem " + Functions.ItoA (  (int) ( POSITION ) )  ) ; 
    __context__.SourceCodeLine = 2038;
    DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
    __context__.SourceCodeLine = 2039;
    BROWSELIST (  __context__ , GSBROWSE, (ushort)( GILISTSTARTPOS ), (ushort)( GIMAXLISTITEMS ), (ushort)( 0 )) ; 
    
    }
    
private void REMOVEFAVORITE (  SplusExecutionContext __context__, CrestronString SGUID ) 
    { 
    CrestronString CMD__DOLLAR__;
    CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    
    __context__.SourceCodeLine = 2045;
    CMD__DOLLAR__  .UpdateValue ( "DeleteFavorite " + SGUID  ) ; 
    __context__.SourceCodeLine = 2046;
    DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
    __context__.SourceCodeLine = 2047;
    BROWSELIST (  __context__ , GSBROWSE, (ushort)( GILISTSTARTPOS ), (ushort)( GIMAXLISTITEMS ), (ushort)( 0 )) ; 
    
    }
    
private void JUMPTOITEM (  SplusExecutionContext __context__, CrestronString SGUID ) 
    { 
    CrestronString CMD__DOLLAR__;
    CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    
    __context__.SourceCodeLine = 2054;
    CMD__DOLLAR__  .UpdateValue ( "JumpToNowPlayingItem " + SGUID  ) ; 
    __context__.SourceCodeLine = 2055;
    DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
    
    }
    
private void JUMPTOITEMBYINDEX (  SplusExecutionContext __context__, ushort INDEX ) 
    { 
    CrestronString CMD__DOLLAR__;
    CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
    
    ushort POSITION = 0;
    
    
    __context__.SourceCodeLine = 2062;
    POSITION = (ushort) ( ((GILISTSTARTPOS + INDEX) - 1) ) ; 
    __context__.SourceCodeLine = 2063;
    CMD__DOLLAR__  .UpdateValue ( "JumpToNowPlayingItem " + Functions.ItoA (  (int) ( POSITION ) )  ) ; 
    __context__.SourceCodeLine = 2064;
    DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
    
    }
    
private void DOSTATUSLINE (  SplusExecutionContext __context__, CrestronString STATUS__DOLLAR__ ) 
    { 
    
    __context__.SourceCodeLine = 2070;
    IP_STATUS  .UpdateValue ( STATUS__DOLLAR__  ) ; 
    
    }
    
private void ONCONNECT (  SplusExecutionContext __context__ ) 
    { 
    CrestronString CMD__DOLLAR__;
    CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    
    __context__.SourceCodeLine = 2078;
    GBIP_ISRUNNING = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 2079;
    DOSTATUSLINE (  __context__ , "Media Server Connected") ; 
    __context__.SourceCodeLine = 2080;
    CLEARALL (  __context__  ) ; 
    __context__.SourceCodeLine = 2084;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GBDEFAULTINSTANCESET == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 2086;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INSTANCE__DOLLAR__ != "*"))  ) ) 
            { 
            __context__.SourceCodeLine = 2088;
            CMD__DOLLAR__  .UpdateValue ( "SetInstance " + Functions.Chr (  (int) ( 34 ) ) + INSTANCE__DOLLAR__ + Functions.Chr (  (int) ( 34 ) )  ) ; 
            __context__.SourceCodeLine = 2089;
            DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
            } 
        
        __context__.SourceCodeLine = 2091;
        GBDEFAULTINSTANCESET = (ushort) ( 1 ) ; 
        } 
    
    __context__.SourceCodeLine = 2094;
    if ( Functions.TestForTrue  ( ( EVENTS_ENABLED  .Value)  ) ) 
        {
        __context__.SourceCodeLine = 2094;
        DOCOMMAND (  __context__ , "SubscribeEvents True") ; 
        }
    
    __context__.SourceCodeLine = 2096;
    DOCOMMAND (  __context__ , "SetClientType Crestron") ; 
    __context__.SourceCodeLine = 2097;
    DOCOMMAND (  __context__ , "SetClientVersion 3.2.5") ; 
    __context__.SourceCodeLine = 2098;
    DOCOMMAND (  __context__ , "SetEncoding 20105") ; 
    __context__.SourceCodeLine = 2099;
    DOCOMMAND (  __context__ , "StartMCE") ; 
    __context__.SourceCodeLine = 2100;
    CMD__DOLLAR__  .UpdateValue ( "SetPicklistCount " + Functions.ItoA (  (int) ( GIMAXLISTITEMS ) )  ) ; 
    __context__.SourceCodeLine = 2101;
    DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
    __context__.SourceCodeLine = 2102;
    DOCOMMAND (  __context__ , "SetOption supports_playnow=true") ; 
    __context__.SourceCodeLine = 2103;
    DOCOMMAND (  __context__ , "GetStatus") ; 
    
    }
    
private void BROWSEALPHA (  SplusExecutionContext __context__, CrestronString MEDIA__DOLLAR__ , CrestronString ALPHA__DOLLAR__ ) 
    { 
    ushort START = 0;
    
    CrestronString CMD__DOLLAR__;
    CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    
    __context__.SourceCodeLine = 2112;
    CMD__DOLLAR__  .UpdateValue ( "Browse" + MEDIA__DOLLAR__ + " " + Functions.Chr (  (int) ( 34 ) ) + ALPHA__DOLLAR__ + Functions.Chr (  (int) ( 34 ) ) + " " + Functions.ItoA (  (int) ( GIMAXLISTITEMS ) )  ) ; 
    __context__.SourceCodeLine = 2115;
    DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
    __context__.SourceCodeLine = 2117;
    ADDTOHISTORY (  __context__ , CMD__DOLLAR__, GSFILTERS) ; 
    __context__.SourceCodeLine = 2120;
    PREV_ENABLE  .Value = (ushort) ( Functions.BoolToInt ( START > 1 ) ) ; 
    __context__.SourceCodeLine = 2121;
    SCROLL_ENABLE  .Value = (ushort) ( Functions.BoolToInt ( (Functions.TestForTrue ( NEXT_ENABLE  .Value ) || Functions.TestForTrue ( PREV_ENABLE  .Value )) ) ) ; 
    
    }
    
private void PAGEADV (  SplusExecutionContext __context__, ushort DIRECTION ) 
    { 
    ushort START = 0;
    ushort COUNT = 0;
    
    
    __context__.SourceCodeLine = 2131;
    
        {
        int __SPLS_TMPVAR__SWTCH_14__ = ((int)DIRECTION);
        
            { 
            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_14__ == ( Functions.BoolToInt ( (Functions.TestForTrue ( 0 ) && Functions.TestForTrue ( Functions.BoolToInt (NEXT_ENABLE  .Value != 0) )) )) ) ) ) 
                { 
                __context__.SourceCodeLine = 2136;
                START = (ushort) ( (GILISTSTARTPOS + GIPAGINGVALUE) ) ; 
                __context__.SourceCodeLine = 2137;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( START > GILISTCOUNT ))  ) ) 
                    {
                    __context__.SourceCodeLine = 2137;
                    START = (ushort) ( GILISTCOUNT ) ; 
                    }
                
                __context__.SourceCodeLine = 2138;
                COUNT = (ushort) ( GIPAGINGVALUE ) ; 
                __context__.SourceCodeLine = 2139;
                BROWSELIST (  __context__ , GSBROWSE, (ushort)( START ), (ushort)( COUNT ), (ushort)( 1 )) ; 
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_14__ == ( Functions.BoolToInt ( (Functions.TestForTrue ( 1 ) && Functions.TestForTrue ( Functions.BoolToInt (PREV_ENABLE  .Value != 0) )) )) ) ) ) 
                { 
                __context__.SourceCodeLine = 2146;
                START = (ushort) ( (GILISTSTARTPOS - GIPAGINGVALUE) ) ; 
                __context__.SourceCodeLine = 2147;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( START < 1 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 2147;
                    START = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 2148;
                COUNT = (ushort) ( GIPAGINGVALUE ) ; 
                __context__.SourceCodeLine = 2149;
                BROWSELIST (  __context__ , GSBROWSE, (ushort)( START ), (ushort)( COUNT ), (ushort)( 1 )) ; 
                } 
            
            } 
            
        }
        
    
    
    }
    
private void SELECT_TITLE (  SplusExecutionContext __context__, ushort LISTINDEX ) 
    { 
    CrestronString SBROWSELIST;
    SBROWSELIST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 48, this );
    
    CrestronString CMD;
    CMD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    
    __context__.SourceCodeLine = 2163;
    GSLISTTYPE  .UpdateValue ( GSTYPE [ LISTINDEX ]  ) ; 
    __context__.SourceCodeLine = 2165;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TITLE_ENABLED[ LISTINDEX ] .Value != 0))  ) ) 
        { 
        __context__.SourceCodeLine = 2167;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSLISTACTIONS[ LISTINDEX ] != ""))  ) ) 
            { 
            __context__.SourceCodeLine = 2169;
            CMD  .UpdateValue ( GSLISTACTIONS [ LISTINDEX ] + " " + GSGUID [ LISTINDEX ]  ) ; 
            __context__.SourceCodeLine = 2170;
            CLEARLIST (  __context__  ) ; 
            __context__.SourceCodeLine = 2171;
            DOCOMMAND (  __context__ , CMD) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2176;
            
                {
                int __SPLS_TMPVAR__SWTCH_15__ = ((int)1);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "Instance")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2180;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2181;
                        IP_STATUS  .UpdateValue ( "Connecting to " + GSITEM [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2182;
                        CMD  .UpdateValue ( "SetInstance " + Functions.Chr (  (int) ( 34 ) ) + GSITEM [ LISTINDEX ] + Functions.Chr (  (int) ( 34 ) )  ) ; 
                        __context__.SourceCodeLine = 2183;
                        DOCOMMAND (  __context__ , CMD) ; 
                        __context__.SourceCodeLine = 2184;
                        ONCONNECT (  __context__  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "InstanceInfoEx")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2190;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2191;
                        IP_STATUS  .UpdateValue ( "Connected to " + GSITEM [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2192;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSSERVER[ LISTINDEX ] == "127.0.0.1"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2193;
                            CMD  .UpdateValue ( "SetInstance " + GSINSTANCE [ LISTINDEX ]  ) ; 
                            __context__.SourceCodeLine = 2194;
                            DOCOMMAND (  __context__ , CMD) ; 
                            __context__.SourceCodeLine = 2195;
                            ONCONNECT (  __context__  ) ; 
                            } 
                        
                        else 
                            { 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "MusicFilter")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2204;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2205;
                        GSFILTERSDESC  .UpdateValue ( GSITEM [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2207;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSITEM[ LISTINDEX ] == "Playlists"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2209;
                            SETFILTER (  __context__ , (ushort)( 1 ), "", (ushort)( 0 )) ; 
                            __context__.SourceCodeLine = 2210;
                            BROWSELIST (  __context__ , GSITEM[ LISTINDEX ], (ushort)( 1 ), (ushort)( GIMAXLISTITEMS ), (ushort)( 1 )) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 2212;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSITEM[ LISTINDEX ] == "Radio"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2214;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 2214;
                                    Print( "Radio Selected") ; 
                                    }
                                
                                __context__.SourceCodeLine = 2215;
                                SETMEDIAMODE (  __context__ , (ushort)( 6 )) ; 
                                __context__.SourceCodeLine = 2216;
                                SETFILTER (  __context__ , (ushort)( 6 ), "", (ushort)( 0 )) ; 
                                __context__.SourceCodeLine = 2217;
                                BROWSELIST (  __context__ , "RadioSources", (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 2221;
                                SETFILTER (  __context__ , (ushort)( 1 ), "", (ushort)( 0 )) ; 
                                __context__.SourceCodeLine = 2222;
                                BROWSELIST (  __context__ , GSITEM[ LISTINDEX ], (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
                                } 
                            
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "MovieFilter")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2230;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2231;
                        SETFILTER (  __context__ , (ushort)( 2 ), "", (ushort)( 0 )) ; 
                        __context__.SourceCodeLine = 2232;
                        GSFILTERSDESC  .UpdateValue ( GSITEM [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2233;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSITEM[ LISTINDEX ] == "Titles"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2235;
                            BROWSELIST (  __context__ , "MovieTitles", (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 2239;
                            SBROWSELIST  .UpdateValue ( "Movie" + GSITEM [ LISTINDEX ]  ) ; 
                            __context__.SourceCodeLine = 2240;
                            BROWSELIST (  __context__ , SBROWSELIST, (ushort)( 1 ), (ushort)( GIMAXLISTITEMS ), (ushort)( 1 )) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "DVRFilter")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2246;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2247;
                        SETFILTER (  __context__ , (ushort)( 3 ), "", (ushort)( 0 )) ; 
                        __context__.SourceCodeLine = 2248;
                        GSFILTERSDESC  .UpdateValue ( GSITEM [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2249;
                        SBROWSELIST  .UpdateValue ( "DVR" + GSITEM [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2250;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SBROWSELIST == "DVRRecorded"))  ) ) 
                            {
                            __context__.SourceCodeLine = 2250;
                            SBROWSELIST  .UpdateValue ( "DVRRecordDates"  ) ; 
                            }
                        
                        __context__.SourceCodeLine = 2251;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SBROWSELIST == "DVRTitles"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2254;
                            BROWSELIST (  __context__ , "DVRTitles", (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 2259;
                            BROWSELIST (  __context__ , SBROWSELIST, (ushort)( 1 ), (ushort)( GIMAXLISTITEMS ), (ushort)( 1 )) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "PictureFolder")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2265;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2266;
                        GSFILTERSDESC  .UpdateValue ( "Pictures"  ) ; 
                        __context__.SourceCodeLine = 2267;
                        CMD  .UpdateValue ( "PictureFolder=" + GSGUID [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2268;
                        SETFILTER (  __context__ , (ushort)( 5 ), CMD, (ushort)( 0 )) ; 
                        __context__.SourceCodeLine = 2269;
                        BROWSELIST (  __context__ , "Pictures", (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "PictureFile")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2274;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2275;
                        PLAYITEM (  __context__ , "SlideShow", GSGUID[ LISTINDEX ], (ushort)( 0 )) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "VideoFolder")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2280;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2281;
                        GSFILTERSDESC  .UpdateValue ( "Videos"  ) ; 
                        __context__.SourceCodeLine = 2282;
                        CMD  .UpdateValue ( "VideoFolder=" + GSGUID [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2283;
                        SETFILTER (  __context__ , (ushort)( 4 ), CMD, (ushort)( 0 )) ; 
                        __context__.SourceCodeLine = 2284;
                        BROWSELIST (  __context__ , "Videos", (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "VideoFile")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2289;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2290;
                        PLAYITEM (  __context__ , "Video", GSGUID[ LISTINDEX ], (ushort)( 0 )) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "Genre")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2296;
                        GSPARENTTYPE  .UpdateValue ( "Genre " + GSGUID [ LISTINDEX ] + " false"  ) ; 
                        __context__.SourceCodeLine = 2297;
                        GSFILTERSDESC  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2298;
                        CMD  .UpdateValue ( "Genre=" + GSGUID [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2299;
                        SETFILTER (  __context__ , (ushort)( 1 ), CMD, (ushort)( 0 )) ; 
                        __context__.SourceCodeLine = 2300;
                        BROWSELIST (  __context__ , "Albums", (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "Artist")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2305;
                        GSPARENTTYPE  .UpdateValue ( "Artist " + GSGUID [ LISTINDEX ] + " false"  ) ; 
                        __context__.SourceCodeLine = 2306;
                        GSFILTERSDESC  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2307;
                        CMD  .UpdateValue ( "Artist=" + GSGUID [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2308;
                        SETFILTER (  __context__ , (ushort)( 1 ), CMD, (ushort)( 0 )) ; 
                        __context__.SourceCodeLine = 2309;
                        BROWSELIST (  __context__ , "Albums", (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "Album")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2314;
                        GSPARENTTYPE  .UpdateValue ( "Album " + GSGUID [ LISTINDEX ] + " false"  ) ; 
                        __context__.SourceCodeLine = 2315;
                        GSFILTERSDESC  .UpdateValue ( GSITEM [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2316;
                        CLEARINFO (  __context__  ) ; 
                        __context__.SourceCodeLine = 2317;
                        GSGUID [ 0 ]  .UpdateValue ( GSGUID [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2318;
                        CMD  .UpdateValue ( "Album=" + GSGUID [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2319;
                        SETFILTER (  __context__ , (ushort)( 1 ), CMD, (ushort)( 0 )) ; 
                        __context__.SourceCodeLine = 2320;
                        BROWSE_ART_FORMAT  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 2321;
                        REFRESH_BROWSING_ART (  __context__ , GSGUID[ LISTINDEX ]) ; 
                        __context__.SourceCodeLine = 2322;
                        PAGEFLIP (  __context__ , (ushort)( 2 )) ; 
                        __context__.SourceCodeLine = 2323;
                        BROWSELIST (  __context__ , "Titles", (ushort)( 1 ), (ushort)( GIMAXLISTITEMS ), (ushort)( 0 )) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "Playlist")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2328;
                        GSPARENTTYPE  .UpdateValue ( "Playlist " + GSGUID [ LISTINDEX ] + " false"  ) ; 
                        __context__.SourceCodeLine = 2329;
                        GSFILTERSDESC  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2330;
                        CMD  .UpdateValue ( "Playlist=" + GSGUID [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2331;
                        SETFILTER (  __context__ , (ushort)( 1 ), CMD, (ushort)( 0 )) ; 
                        __context__.SourceCodeLine = 2332;
                        PAGEFLIP (  __context__ , (ushort)( 3 )) ; 
                        __context__.SourceCodeLine = 2333;
                        BROWSELIST (  __context__ , "Titles", (ushort)( 1 ), (ushort)( GIMAXLISTITEMS ), (ushort)( 1 )) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "Title")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2339;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GIBUTTONSTATE == 2))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2341;
                            CMD  .UpdateValue ( "JumpToNowPlayingItem " + GSGUID [ LISTINDEX ]  ) ; 
                            __context__.SourceCodeLine = 2342;
                            DOCOMMAND (  __context__ , CMD) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 2346;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (GSPARENTTYPE == "") ) || Functions.TestForTrue ( Functions.BoolToInt (GSITEM[ LISTINDEX ] == "Shuffle all") )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2348;
                                CMD  .UpdateValue ( GSGUID [ LISTINDEX ] + " false"  ) ; 
                                __context__.SourceCodeLine = 2349;
                                PLAYITEM (  __context__ , "Title", CMD, (ushort)( 0 )) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 2353;
                                PLAYITEM (  __context__ , GSPARENTTYPE, GSGUID[ LISTINDEX ], (ushort)( 0 )) ; 
                                } 
                            
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "Favorite")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2362;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2363;
                        CMD  .UpdateValue ( "PlayFavorite " + GSGUID [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2364;
                        DOCOMMAND (  __context__ , CMD) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "RadioSource")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2371;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2372;
                        CMD  .UpdateValue ( "RadioSource=" + GSGUID [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2373;
                        SETFILTER (  __context__ , (ushort)( 6 ), CMD, (ushort)( 0 )) ; 
                        __context__.SourceCodeLine = 2375;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSGUID[ LISTINDEX ] == "fbbcedb1-af64-4c3f-bfe5-000000000008"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2377;
                            BROWSELIST (  __context__ , "RadioGenres", (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 2381;
                            BROWSELIST (  __context__ , "RadioStations", (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "RadioGenre")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2387;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2388;
                        CMD  .UpdateValue ( "RadioGenre=" + GSGUID [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2389;
                        SETFILTER (  __context__ , (ushort)( 6 ), CMD, (ushort)( 1 )) ; 
                        __context__.SourceCodeLine = 2390;
                        BROWSELIST (  __context__ , "RadioStations", (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "RadioStation")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2395;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2396;
                        PLAYITEM (  __context__ , "RadioStation", GSGUID[ LISTINDEX ], (ushort)( 0 )) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (Functions.Left( GSLISTTYPE , (int)( 5 ) ) == "Movie")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2402;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2403;
                        CLEARINFO (  __context__  ) ; 
                        __context__.SourceCodeLine = 2404;
                        GSGUID [ 0 ]  .UpdateValue ( GSGUID [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2405;
                        CMD  .UpdateValue ( GSLISTTYPE + "=" + GSGUID [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2406;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSLISTTYPE == "MovieTitle"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2408;
                            SETFILTER (  __context__ , (ushort)( 2 ), CMD, (ushort)( 0 )) ; 
                            __context__.SourceCodeLine = 2409;
                            BROWSE_ART_FORMAT  .Value = (ushort) ( 3 ) ; 
                            __context__.SourceCodeLine = 2410;
                            REFRESH_BROWSING_ART (  __context__ , GSGUID[ LISTINDEX ]) ; 
                            __context__.SourceCodeLine = 2411;
                            GICURRENTPAGE = (ushort) ( 2 ) ; 
                            __context__.SourceCodeLine = 2415;
                            BROWSELIST (  __context__ , "MovieChapters", (ushort)( 1 ), (ushort)( GIMAXLISTITEMS ), (ushort)( 0 )) ; 
                            __context__.SourceCodeLine = 2416;
                            CMD  .UpdateValue ( "GetMovieProperties " + GSGUID [ LISTINDEX ]  ) ; 
                            __context__.SourceCodeLine = 2417;
                            DOCOMMAND (  __context__ , CMD) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 2419;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSLISTTYPE == "MovieChapter"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2421;
                                PLAYITEM (  __context__ , "MovieChapter", GSGUID[ LISTINDEX ], (ushort)( 0 )) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 2425;
                                GSFILTERSDESC  .UpdateValue ( "Movies"  ) ; 
                                __context__.SourceCodeLine = 2426;
                                SETFILTER (  __context__ , (ushort)( 2 ), CMD, (ushort)( 0 )) ; 
                                __context__.SourceCodeLine = 2427;
                                BROWSELIST (  __context__ , "MovieTitles", (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
                                } 
                            
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (Functions.Left( GSLISTTYPE , (int)( 3 ) ) == "Dvr")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2434;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2435;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSLISTTYPE == "DvrTitle"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2437;
                            PLAYITEM (  __context__ , "DvrTitle", GSGUID[ LISTINDEX ], (ushort)( 0 )) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 2441;
                            GSFILTERSDESC  .UpdateValue ( "Recorded TV"  ) ; 
                            __context__.SourceCodeLine = 2442;
                            CMD  .UpdateValue ( GSLISTTYPE + "=" + GSGUID [ LISTINDEX ]  ) ; 
                            __context__.SourceCodeLine = 2443;
                            SETFILTER (  __context__ , (ushort)( 3 ), CMD, (ushort)( 0 )) ; 
                            __context__.SourceCodeLine = 2444;
                            BROWSELIST (  __context__ , "DVRTitles", (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "EpgGenre")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2451;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2452;
                        SETMEDIAMODE (  __context__ , (ushort)( 7 )) ; 
                        __context__.SourceCodeLine = 2453;
                        CMD  .UpdateValue ( "Genre=" + GSGUID [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2454;
                        SETFILTER (  __context__ , (ushort)( 7 ), CMD, (ushort)( 0 )) ; 
                        __context__.SourceCodeLine = 2455;
                        BROWSELIST (  __context__ , "EpgStations", (ushort)( 1 ), (ushort)( GIMAXLISTITEMS ), (ushort)( 1 )) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "EpgStation")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2460;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2461;
                        SETMEDIAMODE (  __context__ , (ushort)( 7 )) ; 
                        __context__.SourceCodeLine = 2462;
                        PLAYITEM (  __context__ , "EPGStation", GSGUID[ LISTINDEX ], (ushort)( 0 )) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( Functions.BoolToInt (GSLISTTYPE == "PickListItem")) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 2467;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 2468;
                        CMD  .UpdateValue ( "AckPickItem " + GSGUID [ LISTINDEX ]  ) ; 
                        __context__.SourceCodeLine = 2469;
                        CLEARLIST (  __context__  ) ; 
                        __context__.SourceCodeLine = 2470;
                        DOCOMMAND (  __context__ , CMD) ; 
                        } 
                    
                    } 
                    
                }
                
            
            } 
        
        } 
    
    
    }
    
private void PLAYNOW_TITLE (  SplusExecutionContext __context__, ushort I ) 
    { 
    
    __context__.SourceCodeLine = 2480;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TITLE_ENABLED[ I ] .Value != 0))  ) ) 
        { 
        __context__.SourceCodeLine = 2482;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GIBUTTONSTATE == 2))  ) ) 
            { 
            __context__.SourceCodeLine = 2485;
            JUMPTOITEMBYINDEX (  __context__ , (ushort)( I )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2489;
            PLAYITEM (  __context__ , GSTYPE[ I ], GSGUID[ I ], (ushort)( 1 )) ; 
            __context__.SourceCodeLine = 2490;
            CAPTION  .UpdateValue ( "Now Playing " + GSITEM [ I ]  ) ; 
            } 
        
        } 
    
    
    }
    
private void ADDTOPLAYLIST_TITLE (  SplusExecutionContext __context__, ushort I ) 
    { 
    CrestronString CMD;
    CMD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
    
    
    __context__.SourceCodeLine = 2500;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TITLE_ENABLED[ I ] .Value != 0))  ) ) 
        { 
        __context__.SourceCodeLine = 2502;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSACTIONS[ I ] != ""))  ) ) 
            { 
            __context__.SourceCodeLine = 2504;
            CMD  .UpdateValue ( GSACTIONS [ I ] + " " + GSGUID [ I ]  ) ; 
            __context__.SourceCodeLine = 2505;
            DOCOMMAND (  __context__ , CMD) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 2507;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSBROWSE == "Favorites"))  ) ) 
                { 
                __context__.SourceCodeLine = 2509;
                REMOVEFAVORITE (  __context__ , GSGUID[ I ]) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 2512;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GIBUTTONSTATE == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2515;
                    REMOVEITEMBYINDEX (  __context__ , (ushort)( I )) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2520;
                    PLAYITEM (  __context__ , GSTYPE[ I ], GSGUID[ I ], (ushort)( 0 )) ; 
                    __context__.SourceCodeLine = 2521;
                    CMD  .UpdateValue ( GSITEM [ I ] + " added to the queue."  ) ; 
                    __context__.SourceCodeLine = 2522;
                    SHOWINSTANTMESSAGEBOX (  __context__ , "Queue", CMD) ; 
                    } 
                
                }
            
            }
        
        } 
    
    
    }
    
private void FNEXTPAGE (  SplusExecutionContext __context__ ) 
    { 
    ushort START = 0;
    ushort COUNT = 0;
    
    
    __context__.SourceCodeLine = 2533;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEXT_ENABLE  .Value != 0))  ) ) 
        { 
        __context__.SourceCodeLine = 2535;
        START = (ushort) ( (GILISTSTARTPOS + GIPAGINGVALUE) ) ; 
        __context__.SourceCodeLine = 2536;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( START > GILISTCOUNT ))  ) ) 
            {
            __context__.SourceCodeLine = 2536;
            START = (ushort) ( GILISTCOUNT ) ; 
            }
        
        __context__.SourceCodeLine = 2537;
        COUNT = (ushort) ( GIPAGINGVALUE ) ; 
        __context__.SourceCodeLine = 2538;
        BROWSELIST (  __context__ , GSBROWSE, (ushort)( START ), (ushort)( COUNT ), (ushort)( 1 )) ; 
        } 
    
    
    }
    
private void FPREVPAGE (  SplusExecutionContext __context__ ) 
    { 
    ushort START = 0;
    ushort COUNT = 0;
    
    
    __context__.SourceCodeLine = 2546;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PREV_ENABLE  .Value != 0))  ) ) 
        { 
        __context__.SourceCodeLine = 2548;
        START = (ushort) ( (GILISTSTARTPOS - GIPAGINGVALUE) ) ; 
        __context__.SourceCodeLine = 2549;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( START < 1 ))  ) ) 
            {
            __context__.SourceCodeLine = 2549;
            START = (ushort) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 2550;
        COUNT = (ushort) ( GIPAGINGVALUE ) ; 
        __context__.SourceCodeLine = 2551;
        BROWSELIST (  __context__ , GSBROWSE, (ushort)( START ), (ushort)( COUNT ), (ushort)( 1 )) ; 
        } 
    
    
    }
    
private void PLAYLISTSAVE (  SplusExecutionContext __context__, CrestronString PLISTNAME__DOLLAR__ ) 
    { 
    CrestronString CMD__DOLLAR__;
    CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    
    
    __context__.SourceCodeLine = 2560;
    CMD__DOLLAR__  .UpdateValue ( "SavePlaylist " + Functions.Chr (  (int) ( 34 ) ) + PLISTNAME__DOLLAR__ + Functions.Chr (  (int) ( 34 ) )  ) ; 
    __context__.SourceCodeLine = 2562;
    DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
    
    }
    
private ushort SEEKCALC (  SplusExecutionContext __context__, ushort SEEKDIR ) 
    { 
    ushort TARGSEC = 0;
    
    
    __context__.SourceCodeLine = 2573;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEEKDIR == 0))  ) ) 
        { 
        __context__.SourceCodeLine = 2575;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (GITRACKTIME - SEEK_DELTA  .Value) < 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 2576;
            TARGSEC = (ushort) ( 0 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2578;
            TARGSEC = (ushort) ( (GITRACKTIME - SEEK_DELTA  .Value) ) ; 
            } 
        
        } 
    
    else 
        {
        __context__.SourceCodeLine = 2583;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEEKDIR == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 2585;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (GITRACKTIME + SEEK_DELTA  .Value) > GITRACKLEN ))  ) ) 
                { 
                __context__.SourceCodeLine = 2586;
                TARGSEC = (ushort) ( GITRACKLEN ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2588;
                TARGSEC = (ushort) ( (GITRACKTIME + SEEK_DELTA  .Value) ) ; 
                } 
            
            } 
        
        }
    
    __context__.SourceCodeLine = 2594;
    return (ushort)( TARGSEC) ; 
    
    }
    
private void PREVENTOVERFLOW (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 2599;
    Trace( "Preventing buffer overflow") ; 
    __context__.SourceCodeLine = 2600;
    Functions.ClearBuffer ( IP_RX__DOLLAR__ ) ; 
    __context__.SourceCodeLine = 2601;
    Functions.ClearBuffer ( GIBUFFERIN__DOLLAR__ ) ; 
    __context__.SourceCodeLine = 2602;
    DOCOMMAND (  __context__ , "GetStatus") ; 
    
    }
    
object CONTEXTBUTTON1_OnPush_0 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2615;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSCONTEXT1__DOLLAR__ == "Now Playing"))  ) ) 
            {
            __context__.SourceCodeLine = 2616;
            PAGEFLIP (  __context__ , (ushort)( 4 )) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2618;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSCONTEXT1__DOLLAR__ == "Actions"))  ) ) 
                { 
                __context__.SourceCodeLine = 2620;
                CLEARLIST (  __context__  ) ; 
                __context__.SourceCodeLine = 2621;
                DOCOMMAND (  __context__ , "AckButton CONTEXT") ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONTEXTBUTTON2_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2628;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSCONTEXT2__DOLLAR__ == "Zones"))  ) ) 
            { 
            __context__.SourceCodeLine = 2630;
            CLEARLIST (  __context__  ) ; 
            __context__.SourceCodeLine = 2631;
            DOCOMMAND (  __context__ , "BrowseInstances") ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 2633;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSCONTEXT2__DOLLAR__ == "Actions"))  ) ) 
                { 
                __context__.SourceCodeLine = 2635;
                CLEARLIST (  __context__  ) ; 
                __context__.SourceCodeLine = 2636;
                DOCOMMAND (  __context__ , "AckButton CONTEXT") ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2640;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSCONTEXT2__DOLLAR__ == "Save Playlist"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2643;
                    MESSAGECAPTION__DOLLAR__  .UpdateValue ( "Save Playlist"  ) ; 
                    __context__.SourceCodeLine = 2644;
                    MESSAGETEXT__DOLLAR__  .UpdateValue ( "Enter a name to save the current queue as a playlist."  ) ; 
                    __context__.SourceCodeLine = 2645;
                    MESSAGEVALUE__DOLLAR__  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 2647;
                    Functions.Pulse ( 10, PAGE_KB_FB ) ; 
                    __context__.SourceCodeLine = 2648;
                    GISAVEPLAYLIST = (ushort) ( 1 ) ; 
                    } 
                
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONTEXTBUTTON3_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString CMD__DOLLAR__;
        CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 48, this );
        
        
        __context__.SourceCodeLine = 2659;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSCONTEXT3__DOLLAR__ == "Clear Queue"))  ) ) 
            { 
            __context__.SourceCodeLine = 2661;
            DOCOMMAND (  __context__ , "ClearNowPLaying") ; 
            __context__.SourceCodeLine = 2663;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GIUICAPABILITIES == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 2665;
                BROWSEFILTERS (  __context__ , "Music") ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2669;
                SETFILTER (  __context__ , (ushort)( 1 ), "", (ushort)( 0 )) ; 
                __context__.SourceCodeLine = 2670;
                BROWSELIST (  __context__ , "Albums", (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 2674;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSCONTEXT3__DOLLAR__ == "Search"))  ) ) 
                { 
                __context__.SourceCodeLine = 2676;
                MESSAGECAPTION__DOLLAR__  .UpdateValue ( "Search"  ) ; 
                __context__.SourceCodeLine = 2677;
                MESSAGETEXT__DOLLAR__  .UpdateValue ( "Enter text to search the current listing."  ) ; 
                __context__.SourceCodeLine = 2678;
                MESSAGEVALUE__DOLLAR__  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 2680;
                Functions.Pulse ( 10, PAGE_KB_FB ) ; 
                __context__.SourceCodeLine = 2682;
                GISEARCHACTIVE = (ushort) ( 1 ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 2684;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSCONTEXT3__DOLLAR__ == "Favorites"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2686;
                    BROWSELIST (  __context__ , "Favorites", (ushort)( 1 ), (ushort)( GIMAXLISTITEMS ), (ushort)( 1 )) ; 
                    } 
                
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONTEXTBUTTON4_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2695;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSCONTEXT4__DOLLAR__ == "Controls"))  ) ) 
            {
            __context__.SourceCodeLine = 2696;
            PAGEFLIP (  __context__ , (ushort)( 0 )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEEK_FORWARD_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2706;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEEK_BACK  .Value != 1) ) && Functions.TestForTrue ( Functions.BoolToInt (GISEEKAVAILABLE == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2708;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEEK_FORWARD  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 2709;
                SEEKBUILDER  .UpdateValue ( "Seek " + Functions.ItoA (  (int) ( SEEKCALC( __context__ , (ushort)( 1 ) ) ) )  ) ; 
                __context__.SourceCodeLine = 2710;
                DOCOMMAND (  __context__ , SEEKBUILDER) ; 
                __context__.SourceCodeLine = 2711;
                Functions.Delay (  (int) ( 50 ) ) ; 
                __context__.SourceCodeLine = 2708;
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEEK_BACK_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2721;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SEEK_FORWARD  .Value != 1) ) && Functions.TestForTrue ( Functions.BoolToInt (GISEEKAVAILABLE == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2723;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEEK_BACK  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 2724;
                SEEKBUILDER  .UpdateValue ( "Seek " + Functions.ItoA (  (int) ( SEEKCALC( __context__ , (ushort)( 0 ) ) ) )  ) ; 
                __context__.SourceCodeLine = 2725;
                DOCOMMAND (  __context__ , SEEKBUILDER) ; 
                __context__.SourceCodeLine = 2726;
                Functions.Delay (  (int) ( 50 ) ) ; 
                __context__.SourceCodeLine = 2723;
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ACTIONS_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2739;
        CLEARLIST (  __context__  ) ; 
        __context__.SourceCodeLine = 2740;
        DOCOMMAND (  __context__ , "AckButton CONTEXT") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONES_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2745;
        CLEARLIST (  __context__  ) ; 
        __context__.SourceCodeLine = 2746;
        DOCOMMAND (  __context__ , "BrowseInstances") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVEPLAYLIST_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2752;
        MESSAGECAPTION__DOLLAR__  .UpdateValue ( "Save Playlist"  ) ; 
        __context__.SourceCodeLine = 2753;
        MESSAGETEXT__DOLLAR__  .UpdateValue ( "Enter a name to save the current queue as a playlist."  ) ; 
        __context__.SourceCodeLine = 2754;
        MESSAGEVALUE__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 2757;
        Functions.Pulse ( 10, PAGE_KB_FB ) ; 
        __context__.SourceCodeLine = 2759;
        GISAVEPLAYLIST = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLEARQUEUE_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString CMD__DOLLAR__;
        CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
        
        
        __context__.SourceCodeLine = 2766;
        DOCOMMAND (  __context__ , "ClearNowPLaying") ; 
        __context__.SourceCodeLine = 2768;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GIUICAPABILITIES == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 2770;
            BROWSEFILTERS (  __context__ , "Music") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2774;
            CMD__DOLLAR__  .UpdateValue ( "BrowseAlbums 1 " + Functions.ItoA (  (int) ( GIMAXLISTITEMS ) )  ) ; 
            __context__.SourceCodeLine = 2775;
            DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEARCH_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2781;
        MESSAGECAPTION__DOLLAR__  .UpdateValue ( "Search"  ) ; 
        __context__.SourceCodeLine = 2782;
        MESSAGETEXT__DOLLAR__  .UpdateValue ( "Enter text to search the current listing."  ) ; 
        __context__.SourceCodeLine = 2783;
        MESSAGEVALUE__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 2785;
        Functions.Pulse ( 10, PAGE_KB_FB ) ; 
        __context__.SourceCodeLine = 2787;
        GISEARCHACTIVE = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GO_BACK_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2796;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GIBACKAVAILABLE == 1))  ) ) 
            {
            __context__.SourceCodeLine = 2796;
            RECALLHISTORY (  __context__  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2796;
            BROWSEFILTERS (  __context__ , "Music") ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ART_ERROR_OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        CrestronString SURL;
        SURL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
        
        
        __context__.SourceCodeLine = 2804;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 2806;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ART_ERROR[ I ] .UshortValue != 0))  ) ) 
            { 
            __context__.SourceCodeLine = 2808;
            SURL  .UpdateValue ( GETARTURL (  __context__ , GSGUID[ I ])  ) ; 
            __context__.SourceCodeLine = 2809;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                {
                __context__.SourceCodeLine = 2809;
                Print( "List Item {0:d}, Error Code {1:d}, Retrying {2}\r\n", (short)I, (short)ART_ERROR[ I ] .UshortValue, SURL ) ; 
                }
            
            __context__.SourceCodeLine = 2810;
            LISTART__DOLLAR__ [ I]  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 2811;
            Functions.Delay (  (int) ( 5 ) ) ; 
            __context__.SourceCodeLine = 2812;
            LISTART__DOLLAR__ [ I]  .UpdateValue ( SURL  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object COMMAND__DOLLAR___OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString CMD__DOLLAR__;
        CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
        
        ushort FIRSTCHAR = 0;
        
        
        __context__.SourceCodeLine = 2821;
        CMD__DOLLAR__  .UpdateValue ( COMMAND__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 2823;
        Functions.ProcessLogic ( ) ; 
        __context__.SourceCodeLine = 2825;
        
            {
            int __SPLS_TMPVAR__SWTCH_16__ = ((int)1);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_16__ == ( Functions.BoolToInt (Functions.Left( CMD__DOLLAR__ , (int)( 7 ) ) == "Browse ")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 2830;
                    BROWSEFILTERS (  __context__ , Functions.Mid( CMD__DOLLAR__ , (int)( 8 ) , (int)( 15 ) )) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_16__ == ( Functions.BoolToInt (Functions.Left( CMD__DOLLAR__ , (int)( 6 ) ) == "Browse")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 2840;
                    DOCOMMAND (  __context__ , "SetRadioFilter Clear") ; 
                    __context__.SourceCodeLine = 2841;
                    DOCOMMAND (  __context__ , "SetMediaFilter Clear") ; 
                    __context__.SourceCodeLine = 2843;
                    GSFILTERSDESC  .UpdateValue ( Functions.Mid ( CMD__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( 32 ) )  ) ; 
                    __context__.SourceCodeLine = 2844;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSFILTERSDESC == "RadioStations"))  ) ) 
                        {
                        __context__.SourceCodeLine = 2844;
                        GSFILTERSDESC  .UpdateValue ( "Radio Stations"  ) ; 
                        }
                    
                    __context__.SourceCodeLine = 2845;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSFILTERSDESC == "RadioSources"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2847;
                        GSFILTERSDESC  .UpdateValue ( "Radio Sources"  ) ; 
                        __context__.SourceCodeLine = 2848;
                        SETMEDIAMODE (  __context__ , (ushort)( 6 )) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 2852;
                        SETMEDIAMODE (  __context__ , (ushort)( 1 )) ; 
                        } 
                    
                    __context__.SourceCodeLine = 2855;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD__DOLLAR__ , (int)( 7 ) , (int)( 32 ) ) == "Titles"))  ) ) 
                        {
                        __context__.SourceCodeLine = 2855;
                        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
                        }
                    
                    __context__.SourceCodeLine = 2857;
                    BROWSELIST (  __context__ , Functions.Mid( CMD__DOLLAR__ , (int)( 7 ) , (int)( 32 ) ), (ushort)( 1 ), (ushort)( GIMAXLISTITEMS ), (ushort)( 1 )) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_16__ == ( Functions.BoolToInt (CMD__DOLLAR__ == "ClearNowPlaying")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 2862;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GSBROWSE == "NowPlaying"))  ) ) 
                        {
                        __context__.SourceCodeLine = 2862;
                        CLEARALL (  __context__  ) ; 
                        }
                    
                    __context__.SourceCodeLine = 2863;
                    CAPTION  .UpdateValue ( "Play Queue Cleared."  ) ; 
                    __context__.SourceCodeLine = 2864;
                    GITOTALTRACKS = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 2865;
                    DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_16__ == ( Functions.BoolToInt (Functions.Left( CMD__DOLLAR__ , (int)( 3 ) ) == "KB ")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 2870;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GIKBUI == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2872;
                        GIKBUI = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 2873;
                        CMD__DOLLAR__  .UpdateValue ( GSMSGACTIONS [ 1 ] + " OK " + Functions.Chr (  (int) ( 34 ) ) + Functions.Mid ( CMD__DOLLAR__ ,  (int) ( 4 ) ,  (int) ( 128 ) ) + Functions.Chr (  (int) ( 34 ) )  ) ; 
                        __context__.SourceCodeLine = 2874;
                        DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 2878;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GISAVEPLAYLIST == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2880;
                            GISAVEPLAYLIST = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 2881;
                            PLAYLISTSAVE (  __context__ , Functions.Mid( CMD__DOLLAR__ , (int)( 4 ) , (int)( 128 ) )) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 2885;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( CMD__DOLLAR__ ) == 4))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2887;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ALPHA_ENABLED_FB  .Value >= 1 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2889;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                                        {
                                        __context__.SourceCodeLine = 2889;
                                        Print( "Alpha Enabled \u000D") ; 
                                        }
                                    
                                    __context__.SourceCodeLine = 2890;
                                    BROWSEALPHA (  __context__ , GSBROWSE, Functions.Mid( CMD__DOLLAR__ , (int)( 4 ) , (int)( 1 ) )) ; 
                                    } 
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 2895;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GISEARCHACTIVE == 1))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2897;
                                    GISEARCHACTIVE = (ushort) ( 0 ) ; 
                                    __context__.SourceCodeLine = 2898;
                                    CMD__DOLLAR__  .UpdateValue ( "Search=" + Functions.Chr (  (int) ( 34 ) ) + "*" + Functions.Mid ( CMD__DOLLAR__ ,  (int) ( 4 ) ,  (int) ( 128 ) ) + "*" + Functions.Chr (  (int) ( 34 ) )  ) ; 
                                    __context__.SourceCodeLine = 2899;
                                    SETFILTER (  __context__ , (ushort)( GIBROWSINGMEDIA ), CMD__DOLLAR__, (ushort)( 1 )) ; 
                                    __context__.SourceCodeLine = 2900;
                                    BROWSELIST (  __context__ , GSBROWSE, (ushort)( 1 ), (ushort)( GIMAXLISTITEMS ), (ushort)( 1 )) ; 
                                    } 
                                
                                } 
                            
                            } 
                        
                        } 
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_16__ == ( Functions.BoolToInt (Functions.Left( CMD__DOLLAR__ , (int)( 8 ) ) == "KBCANCEL")) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 2908;
                    GIKBUI = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 2909;
                    CMD__DOLLAR__  .UpdateValue ( GSMSGACTIONS [ 1 ] + " CANCEL"  ) ; 
                    __context__.SourceCodeLine = 2910;
                    DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2915;
                    DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
                    } 
                
                } 
                
            }
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONNECT_OnChange_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2923;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CONNECT  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 2924;
            GBDEFAULTINSTANCESET = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2925;
            Functions.ClearBuffer ( IP_RX__DOLLAR__ ) ; 
            } 
        
        __context__.SourceCodeLine = 2927;
        TO_IP_CONNECT  .Value = (ushort) ( CONNECT  .Value ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIALOG_BUTTON_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2932;
        DOCOMMAND (  __context__ , GSMSGACTIONS[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ]) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIRECT_VOLUME_OnChange_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString CMD__DOLLAR__;
        CMD__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 12, this );
        
        
        __context__.SourceCodeLine = 2938;
        CMD__DOLLAR__  .UpdateValue ( "SetVolume " + Functions.ItoA (  (int) ( DIRECT_VOLUME  .UshortValue ) )  ) ; 
        __context__.SourceCodeLine = 2939;
        DOCOMMAND (  __context__ , CMD__DOLLAR__) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EVENTS_ENABLED_OnChange_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2945;
        if ( Functions.TestForTrue  ( ( EVENTS_ENABLED  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 2945;
            DOCOMMAND (  __context__ , "SubscribeEvents True") ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2946;
            DOCOMMAND (  __context__ , "SubscribeEvents False") ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IP_RX__DOLLAR___OnChange_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2953;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( DEBUG  .Value ) && Functions.TestForTrue ( SUPERDEBUG )) ))  ) ) 
            {
            __context__.SourceCodeLine = 2953;
            Trace( "RX buffer changed size {0:d}", (short)Functions.Length( IP_RX__DOLLAR__ )) ; 
            }
        
        __context__.SourceCodeLine = 2954;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( DEBUG  .Value ) && Functions.TestForTrue ( SUPERDEBUG )) ))  ) ) 
            {
            __context__.SourceCodeLine = 2954;
            Trace( "RX buffer with content: {0}", IP_RX__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 2955;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( DEBUG  .Value ) && Functions.TestForTrue ( SUPERDEBUG )) ))  ) ) 
            {
            __context__.SourceCodeLine = 2955;
            Trace( "giBufferActive {0:d}", (short)GIBUFFERACTIVE) ; 
            }
        
        __context__.SourceCodeLine = 2957;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GIBUFFERACTIVE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 2958;
            GIBUFFERACTIVE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 2959;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( DEBUG  .Value ) && Functions.TestForTrue ( SUPERDEBUG )) ))  ) ) 
                {
                __context__.SourceCodeLine = 2959;
                Trace( "giBufferActive {0:d}", (short)GIBUFFERACTIVE) ; 
                }
            
            __context__.SourceCodeLine = 2960;
            do 
                { 
                __context__.SourceCodeLine = 2962;
                GIBUFFERIN__DOLLAR__  .UpdateValue ( Functions.Gather ( "\r\n" , IP_RX__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 2963;
                PARSETOKEN (  __context__ , GIBUFFERIN__DOLLAR__) ; 
                __context__.SourceCodeLine = 2964;
                Functions.ClearBuffer ( GIBUFFERIN__DOLLAR__ ) ; 
                } 
            while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (Functions.Find( "\r\n" , IP_RX__DOLLAR__ ) == 0)) )); 
            __context__.SourceCodeLine = 2966;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( IP_RX__DOLLAR__ ) >= 16000 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2967;
                Trace( "MMS IP_RX$ buffer full, preventing overflow, size {0:d}", (short)Functions.Length( IP_RX__DOLLAR__ )) ; 
                __context__.SourceCodeLine = 2968;
                Trace( "MMS IP_RX$ buffer content: {0}", IP_RX__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 2969;
                PREVENTOVERFLOW (  __context__  ) ; 
                } 
            
            __context__.SourceCodeLine = 2971;
            GIBUFFERACTIVE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2972;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( DEBUG  .Value ) && Functions.TestForTrue ( SUPERDEBUG )) ))  ) ) 
                {
                __context__.SourceCodeLine = 2972;
                Trace( "giBufferActive {0:d}", (short)GIBUFFERACTIVE) ; 
                }
            
            } 
        
        __context__.SourceCodeLine = 2974;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( DEBUG  .Value ) && Functions.TestForTrue ( SUPERDEBUG )) ))  ) ) 
            {
            __context__.SourceCodeLine = 2974;
            Trace( "giBufferActive {0:d}", (short)GIBUFFERACTIVE) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LISTITEMSCOUNT_OnChange_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2979;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LISTITEMSCOUNT  .UshortValue > 10 ))  ) ) 
            { 
            __context__.SourceCodeLine = 2979;
            GIMAXLISTITEMS = (ushort) ( 10 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2979;
            GIMAXLISTITEMS = (ushort) ( LISTITEMSCOUNT  .UshortValue ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAGE_FB_OnChange_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2984;
        GICURRENTPAGE = (ushort) ( PAGE_FB  .UshortValue ) ; 
        __context__.SourceCodeLine = 2986;
        GETCONTEXTBUTTONSTATES (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object THUMBNAILSCOUNT_OnChange_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2992;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( THUMBNAILSCOUNT  .UshortValue > 10 ))  ) ) 
            { 
            __context__.SourceCodeLine = 2992;
            GIMAXTHUMBNAILS = (ushort) ( 10 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2992;
            GIMAXTHUMBNAILS = (ushort) ( THUMBNAILSCOUNT  .UshortValue ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SERVICE_OnChange_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString CMD;
        CMD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
        
        
        __context__.SourceCodeLine = 2999;
        GSPARENTTYPE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 3000;
        CMD  .UpdateValue ( "RadioSource=" + SERVICE  ) ; 
        __context__.SourceCodeLine = 3001;
        SETFILTER (  __context__ , (ushort)( 6 ), CMD, (ushort)( 0 )) ; 
        __context__.SourceCodeLine = 3003;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SERVICE == "fbbcedb1-af64-4c3f-bfe5-000000000008"))  ) ) 
            { 
            __context__.SourceCodeLine = 3005;
            BROWSELIST (  __context__ , "RadioGenres", (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 3009;
            BROWSELIST (  __context__ , "RadioStations", (ushort)( 1 ), (ushort)( GIMAXTHUMBNAILS ), (ushort)( 1 )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCROLLBAR_POSITION_OnChange_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ISTART = 0;
        
        
        __context__.SourceCodeLine = 3017;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SCROLL_ENABLE  .Value != 0))  ) ) 
            { 
            __context__.SourceCodeLine = 3019;
            if ( Functions.TestForTrue  ( ( Functions.Not( GIBUSY ))  ) ) 
                { 
                __context__.SourceCodeLine = 3021;
                GIBUSY = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 3022;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GIPAGINGVALUE == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 3022;
                    GIPAGINGVALUE = (ushort) ( GIMAXTHUMBNAILS ) ; 
                    }
                
                __context__.SourceCodeLine = 3023;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GILISTCOUNT > GIPAGINGVALUE ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 3024;
                    ISTART = (ushort) ( ((65535 - SCROLLBAR_POSITION  .UshortValue) / (65535 / GILISTCOUNT)) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 3026;
                    ISTART = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 3028;
                BROWSELIST (  __context__ , GSBROWSE, (ushort)( ISTART ), (ushort)( GIPAGINGVALUE ), (ushort)( 1 )) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NEXTPAGE_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3036;
        FNEXTPAGE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PREVPAGE_OnPush_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3041;
        FPREVPAGE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIST_ADDTOQUEUE_OnPush_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3046;
        PLAYITEM (  __context__ , GSLISTTYPE, GSGUID[ 0 ], (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIST_PLAYNOW_OnPush_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3051;
        PLAYITEM (  __context__ , GSLISTTYPE, GSGUID[ 0 ], (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object THUMBSDOWN_OnPush_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3056;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( THUMBSUP_ENABLED_FB  .Value > 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 3056;
            DOCOMMAND (  __context__ , "ThumbsDown") ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object THUMBSUP_OnPush_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3061;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( THUMBSDOWN_ENABLED_FB  .Value > 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 3061;
            DOCOMMAND (  __context__ , "ThumbsUp") ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOME_OnPush_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3067;
        BROWSELIST (  __context__ , GSBROWSE, (ushort)( 1 ), (ushort)( GIPAGINGVALUE ), (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object END_OnPush_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3073;
        BROWSELIST (  __context__ , GSBROWSE, (ushort)( ((GILISTCOUNT - GIPAGINGVALUE) + 1) ), (ushort)( GIPAGINGVALUE ), (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TITLE_ADDTOPLAYLIST_OnPush_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 3079;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 3080;
        ADDTOPLAYLIST_TITLE (  __context__ , (ushort)( I )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TITLE_PLAYNOW_OnPush_33 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 3086;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 3087;
        PLAYNOW_TITLE (  __context__ , (ushort)( I )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TITLE_SELECT_OnPush_34 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort LISTINDEX = 0;
        
        
        __context__.SourceCodeLine = 3115;
        LISTINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 3118;
        SELECT_TITLE (  __context__ , (ushort)( LISTINDEX )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETOSD_OnPush_35 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3130;
        PREVENTOVERFLOW (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_IP_CLIENT_STATUS_OnChange_36 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString S__DOLLAR__;
        S__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
        
        
        __context__.SourceCodeLine = 3141;
        
            {
            int __SPLS_TMPVAR__SWTCH_17__ = ((int)FROM_IP_CLIENT_STATUS  .UshortValue);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 0) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 3145;
                    PAGE_MESSAGE_FB  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 3146;
                    TO_IP_CONNECT  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 3147;
                    GBIP_ISRUNNING = (ushort) ( 0 ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 3152;
                    PAGE_MESSAGE_FB  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 3153;
                    DOSTATUSLINE (  __context__ , "Waiting for TCP/IP connection") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 3158;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                        {
                        __context__.SourceCodeLine = 3158;
                        Print( "Switch 2:  TCP/IP Connected\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 3159;
                    DOSTATUSLINE (  __context__ , "Connected to Server") ; 
                    __context__.SourceCodeLine = 3160;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEBUG  .Value == 1))  ) ) 
                        {
                        __context__.SourceCodeLine = 3160;
                        Print( "invoke onConnect function\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 3161;
                    ONCONNECT (  __context__  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 3) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 3166;
                    DOSTATUSLINE (  __context__ , "TCP/IP connection failed") ; 
                    __context__.SourceCodeLine = 3167;
                    TO_IP_CONNECT  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 3168;
                    GBIP_ISRUNNING = (ushort) ( 0 ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 4) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 3173;
                    PAGE_MESSAGE_FB  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 3174;
                    DOSTATUSLINE (  __context__ , "TCP/IP connection broken remotely") ; 
                    __context__.SourceCodeLine = 3175;
                    TO_IP_CONNECT  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 3176;
                    GBIP_ISRUNNING = (ushort) ( 0 ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 5) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 3181;
                    PAGE_MESSAGE_FB  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 3182;
                    DOSTATUSLINE (  __context__ , "TCP/IP connection broken locally") ; 
                    __context__.SourceCodeLine = 3183;
                    TO_IP_CONNECT  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 3184;
                    GBIP_ISRUNNING = (ushort) ( 0 ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 6) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 3189;
                    PAGE_MESSAGE_FB  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 3190;
                    DOSTATUSLINE (  __context__ , "Doing DNS lookup") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 7) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 3195;
                    PAGE_MESSAGE_FB  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 3196;
                    DOSTATUSLINE (  __context__ , "DNS lookup failed - aborting") ; 
                    __context__.SourceCodeLine = 3197;
                    TO_IP_CONNECT  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 3198;
                    GBIP_ISRUNNING = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 3203;
                    PAGE_MESSAGE_FB  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 3204;
                    S__DOLLAR__  .UpdateValue ( "Unknown TCP/IP status: " + Functions.ItoA (  (int) ( FROM_IP_CLIENT_STATUS  .UshortValue ) )  ) ; 
                    __context__.SourceCodeLine = 3205;
                    DOSTATUSLINE (  __context__ , S__DOLLAR__) ; 
                    __context__.SourceCodeLine = 3206;
                    TO_IP_CONNECT  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 3207;
                    GBIP_ISRUNNING = (ushort) ( 0 ) ; 
                    } 
                
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
        
        __context__.SourceCodeLine = 3220;
        GIBUTTONSTATE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 3221;
        GIBUFFERACTIVE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 3222;
        BACK_ENABLE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 3223;
        GIPAGINGVALUE = (ushort) ( GIMAXTHUMBNAILS ) ; 
        __context__.SourceCodeLine = 3224;
        GICURRENTPAGE = (ushort) ( 99 ) ; 
        __context__.SourceCodeLine = 3225;
        SUPERDEBUG = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 3227;
        SETFILTERCONTEXT (  __context__  ) ; 
        __context__.SourceCodeLine = 3228;
        GETCONTEXTBUTTONSTATES (  __context__  ) ; 
        __context__.SourceCodeLine = 3230;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 3232;
        do 
            { 
            __context__.SourceCodeLine = 3233;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (GBIP_ISRUNNING == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (CONNECT  .Value == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 3235;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TO_IP_CONNECT  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 3237;
                    TO_IP_CONNECT  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 3238;
                    Functions.Delay (  (int) ( 200 ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 3240;
                TO_IP_CONNECT  .Value = (ushort) ( 1 ) ; 
                } 
            
            __context__.SourceCodeLine = 3242;
            Functions.Delay (  (int) ( 2000 ) ) ; 
            } 
        while (false == ( Functions.TestForTrue  (  (int) ( 0 ) ) )); 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    GICTLPORT  = new ushort[ 26 ];
    GIBUFFERIN__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16384, this );
    GSCONTEXT1__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
    GSCONTEXT2__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
    GSCONTEXT3__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
    GSCONTEXT4__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
    GSLISTTYPE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16, this );
    GSBROWSE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    GSFILTERS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, this );
    GSFILTERSDESC  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    GSNOWPLAYINGGUID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    GSCAST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
    GSPARENTTYPE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
    GSARTSERVER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    GSNOWPLAYINGSOURCE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    SEEKBUILDER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    GSGUID  = new CrestronString[ 26 ];
    for( uint i = 0; i < 26; i++ )
        GSGUID [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    GSITEM  = new CrestronString[ 26 ];
    for( uint i = 0; i < 26; i++ )
        GSITEM [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
    GSTYPE  = new CrestronString[ 26 ];
    for( uint i = 0; i < 26; i++ )
        GSTYPE [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    GSINSTANCE  = new CrestronString[ 26 ];
    for( uint i = 0; i < 26; i++ )
        GSINSTANCE [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    GSACTIONS  = new CrestronString[ 26 ];
    for( uint i = 0; i < 26; i++ )
        GSACTIONS [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
    GSLISTACTIONS  = new CrestronString[ 26 ];
    for( uint i = 0; i < 26; i++ )
        GSLISTACTIONS [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    GSFILTERCONTEXT  = new CrestronString[ 7 ];
    for( uint i = 0; i < 7; i++ )
        GSFILTERCONTEXT [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    GSSERVER  = new CrestronString[ 26 ];
    for( uint i = 0; i < 26; i++ )
        GSSERVER [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 128, this );
    GSMSGACTIONS  = new CrestronString[ 4 ];
    for( uint i = 0; i < 4; i++ )
        GSMSGACTIONS [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
    HISTORY  = new STRUCT_HISTORY[ 6 ];
    for( uint i = 0; i < 6; i++ )
    {
        HISTORY [i] = new STRUCT_HISTORY( this, true );
        HISTORY [i].PopulateCustomAttributeList( false );
        
    }
    
    PREVPAGE = new Crestron.Logos.SplusObjects.DigitalInput( PREVPAGE__DigitalInput__, this );
    m_DigitalInputList.Add( PREVPAGE__DigitalInput__, PREVPAGE );
    
    NEXTPAGE = new Crestron.Logos.SplusObjects.DigitalInput( NEXTPAGE__DigitalInput__, this );
    m_DigitalInputList.Add( NEXTPAGE__DigitalInput__, NEXTPAGE );
    
    HOME = new Crestron.Logos.SplusObjects.DigitalInput( HOME__DigitalInput__, this );
    m_DigitalInputList.Add( HOME__DigitalInput__, HOME );
    
    END = new Crestron.Logos.SplusObjects.DigitalInput( END__DigitalInput__, this );
    m_DigitalInputList.Add( END__DigitalInput__, END );
    
    CONNECT = new Crestron.Logos.SplusObjects.DigitalInput( CONNECT__DigitalInput__, this );
    m_DigitalInputList.Add( CONNECT__DigitalInput__, CONNECT );
    
    EVENTS_ENABLED = new Crestron.Logos.SplusObjects.DigitalInput( EVENTS_ENABLED__DigitalInput__, this );
    m_DigitalInputList.Add( EVENTS_ENABLED__DigitalInput__, EVENTS_ENABLED );
    
    GO_BACK = new Crestron.Logos.SplusObjects.DigitalInput( GO_BACK__DigitalInput__, this );
    m_DigitalInputList.Add( GO_BACK__DigitalInput__, GO_BACK );
    
    LIST_ADDTOQUEUE = new Crestron.Logos.SplusObjects.DigitalInput( LIST_ADDTOQUEUE__DigitalInput__, this );
    m_DigitalInputList.Add( LIST_ADDTOQUEUE__DigitalInput__, LIST_ADDTOQUEUE );
    
    LIST_PLAYNOW = new Crestron.Logos.SplusObjects.DigitalInput( LIST_PLAYNOW__DigitalInput__, this );
    m_DigitalInputList.Add( LIST_PLAYNOW__DigitalInput__, LIST_PLAYNOW );
    
    THUMBSUP = new Crestron.Logos.SplusObjects.DigitalInput( THUMBSUP__DigitalInput__, this );
    m_DigitalInputList.Add( THUMBSUP__DigitalInput__, THUMBSUP );
    
    THUMBSDOWN = new Crestron.Logos.SplusObjects.DigitalInput( THUMBSDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( THUMBSDOWN__DigitalInput__, THUMBSDOWN );
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    SETOSD = new Crestron.Logos.SplusObjects.DigitalInput( SETOSD__DigitalInput__, this );
    m_DigitalInputList.Add( SETOSD__DigitalInput__, SETOSD );
    
    CONTEXTBUTTON1 = new Crestron.Logos.SplusObjects.DigitalInput( CONTEXTBUTTON1__DigitalInput__, this );
    m_DigitalInputList.Add( CONTEXTBUTTON1__DigitalInput__, CONTEXTBUTTON1 );
    
    CONTEXTBUTTON2 = new Crestron.Logos.SplusObjects.DigitalInput( CONTEXTBUTTON2__DigitalInput__, this );
    m_DigitalInputList.Add( CONTEXTBUTTON2__DigitalInput__, CONTEXTBUTTON2 );
    
    CONTEXTBUTTON3 = new Crestron.Logos.SplusObjects.DigitalInput( CONTEXTBUTTON3__DigitalInput__, this );
    m_DigitalInputList.Add( CONTEXTBUTTON3__DigitalInput__, CONTEXTBUTTON3 );
    
    CONTEXTBUTTON4 = new Crestron.Logos.SplusObjects.DigitalInput( CONTEXTBUTTON4__DigitalInput__, this );
    m_DigitalInputList.Add( CONTEXTBUTTON4__DigitalInput__, CONTEXTBUTTON4 );
    
    ACTIONS = new Crestron.Logos.SplusObjects.DigitalInput( ACTIONS__DigitalInput__, this );
    m_DigitalInputList.Add( ACTIONS__DigitalInput__, ACTIONS );
    
    SAVEPLAYLIST = new Crestron.Logos.SplusObjects.DigitalInput( SAVEPLAYLIST__DigitalInput__, this );
    m_DigitalInputList.Add( SAVEPLAYLIST__DigitalInput__, SAVEPLAYLIST );
    
    SEARCH = new Crestron.Logos.SplusObjects.DigitalInput( SEARCH__DigitalInput__, this );
    m_DigitalInputList.Add( SEARCH__DigitalInput__, SEARCH );
    
    CLEARQUEUE = new Crestron.Logos.SplusObjects.DigitalInput( CLEARQUEUE__DigitalInput__, this );
    m_DigitalInputList.Add( CLEARQUEUE__DigitalInput__, CLEARQUEUE );
    
    ZONES = new Crestron.Logos.SplusObjects.DigitalInput( ZONES__DigitalInput__, this );
    m_DigitalInputList.Add( ZONES__DigitalInput__, ZONES );
    
    SEEK_BACK = new Crestron.Logos.SplusObjects.DigitalInput( SEEK_BACK__DigitalInput__, this );
    m_DigitalInputList.Add( SEEK_BACK__DigitalInput__, SEEK_BACK );
    
    SEEK_FORWARD = new Crestron.Logos.SplusObjects.DigitalInput( SEEK_FORWARD__DigitalInput__, this );
    m_DigitalInputList.Add( SEEK_FORWARD__DigitalInput__, SEEK_FORWARD );
    
    DIALOG_BUTTON = new InOutArray<DigitalInput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        DIALOG_BUTTON[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( DIALOG_BUTTON__DigitalInput__ + i, DIALOG_BUTTON__DigitalInput__, this );
        m_DigitalInputList.Add( DIALOG_BUTTON__DigitalInput__ + i, DIALOG_BUTTON[i+1] );
    }
    
    TITLE_SELECT = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        TITLE_SELECT[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( TITLE_SELECT__DigitalInput__ + i, TITLE_SELECT__DigitalInput__, this );
        m_DigitalInputList.Add( TITLE_SELECT__DigitalInput__ + i, TITLE_SELECT[i+1] );
    }
    
    TITLE_ADDTOPLAYLIST = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        TITLE_ADDTOPLAYLIST[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( TITLE_ADDTOPLAYLIST__DigitalInput__ + i, TITLE_ADDTOPLAYLIST__DigitalInput__, this );
        m_DigitalInputList.Add( TITLE_ADDTOPLAYLIST__DigitalInput__ + i, TITLE_ADDTOPLAYLIST[i+1] );
    }
    
    TITLE_PLAYNOW = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        TITLE_PLAYNOW[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( TITLE_PLAYNOW__DigitalInput__ + i, TITLE_PLAYNOW__DigitalInput__, this );
        m_DigitalInputList.Add( TITLE_PLAYNOW__DigitalInput__ + i, TITLE_PLAYNOW[i+1] );
    }
    
    TO_IP_CONNECT = new Crestron.Logos.SplusObjects.DigitalOutput( TO_IP_CONNECT__DigitalOutput__, this );
    m_DigitalOutputList.Add( TO_IP_CONNECT__DigitalOutput__, TO_IP_CONNECT );
    
    PAGE_HOME_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PAGE_HOME_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PAGE_HOME_FB__DigitalOutput__, PAGE_HOME_FB );
    
    PAGE_DETAILS_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PAGE_DETAILS_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PAGE_DETAILS_FB__DigitalOutput__, PAGE_DETAILS_FB );
    
    PAGE_NOWPLAYING_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PAGE_NOWPLAYING_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PAGE_NOWPLAYING_FB__DigitalOutput__, PAGE_NOWPLAYING_FB );
    
    PAGE_THUMBNAILS_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PAGE_THUMBNAILS_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PAGE_THUMBNAILS_FB__DigitalOutput__, PAGE_THUMBNAILS_FB );
    
    PAGE_LIST_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PAGE_LIST_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PAGE_LIST_FB__DigitalOutput__, PAGE_LIST_FB );
    
    PAGE_MOVIE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PAGE_MOVIE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PAGE_MOVIE_FB__DigitalOutput__, PAGE_MOVIE_FB );
    
    PAGE_MESSAGE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PAGE_MESSAGE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PAGE_MESSAGE_FB__DigitalOutput__, PAGE_MESSAGE_FB );
    
    PAGE_SYNOPSIS_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PAGE_SYNOPSIS_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PAGE_SYNOPSIS_FB__DigitalOutput__, PAGE_SYNOPSIS_FB );
    
    PAGE_CHAPTERS_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PAGE_CHAPTERS_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PAGE_CHAPTERS_FB__DigitalOutput__, PAGE_CHAPTERS_FB );
    
    PAGE_KB_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PAGE_KB_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PAGE_KB_FB__DigitalOutput__, PAGE_KB_FB );
    
    REFRESH = new Crestron.Logos.SplusObjects.DigitalOutput( REFRESH__DigitalOutput__, this );
    m_DigitalOutputList.Add( REFRESH__DigitalOutput__, REFRESH );
    
    SEARCH_ENABLED_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SEARCH_ENABLED_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SEARCH_ENABLED_FB__DigitalOutput__, SEARCH_ENABLED_FB );
    
    DIALOG_ENABLED_FB = new Crestron.Logos.SplusObjects.DigitalOutput( DIALOG_ENABLED_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( DIALOG_ENABLED_FB__DigitalOutput__, DIALOG_ENABLED_FB );
    
    ALPHA_ENABLED_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ALPHA_ENABLED_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ALPHA_ENABLED_FB__DigitalOutput__, ALPHA_ENABLED_FB );
    
    LISTITEMSCOUNT = new Crestron.Logos.SplusObjects.AnalogInput( LISTITEMSCOUNT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( LISTITEMSCOUNT__AnalogSerialInput__, LISTITEMSCOUNT );
    
    THUMBNAILSCOUNT = new Crestron.Logos.SplusObjects.AnalogInput( THUMBNAILSCOUNT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( THUMBNAILSCOUNT__AnalogSerialInput__, THUMBNAILSCOUNT );
    
    FROM_IP_CLIENT_STATUS = new Crestron.Logos.SplusObjects.AnalogInput( FROM_IP_CLIENT_STATUS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FROM_IP_CLIENT_STATUS__AnalogSerialInput__, FROM_IP_CLIENT_STATUS );
    
    SCROLLBAR_POSITION = new Crestron.Logos.SplusObjects.AnalogInput( SCROLLBAR_POSITION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SCROLLBAR_POSITION__AnalogSerialInput__, SCROLLBAR_POSITION );
    
    PAGE_FB = new Crestron.Logos.SplusObjects.AnalogInput( PAGE_FB__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PAGE_FB__AnalogSerialInput__, PAGE_FB );
    
    DIRECT_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( DIRECT_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DIRECT_VOLUME__AnalogSerialInput__, DIRECT_VOLUME );
    
    NOWPLAYING_ART_HEIGHT = new Crestron.Logos.SplusObjects.AnalogInput( NOWPLAYING_ART_HEIGHT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NOWPLAYING_ART_HEIGHT__AnalogSerialInput__, NOWPLAYING_ART_HEIGHT );
    
    NOWPLAYING_ART_WIDTH = new Crestron.Logos.SplusObjects.AnalogInput( NOWPLAYING_ART_WIDTH__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NOWPLAYING_ART_WIDTH__AnalogSerialInput__, NOWPLAYING_ART_WIDTH );
    
    ART_ERROR = new InOutArray<AnalogInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        ART_ERROR[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( ART_ERROR__AnalogSerialInput__ + i, ART_ERROR__AnalogSerialInput__, this );
        m_AnalogInputList.Add( ART_ERROR__AnalogSerialInput__ + i, ART_ERROR[i+1] );
    }
    
    ACTIONS_ENABLED_FB = new Crestron.Logos.SplusObjects.AnalogOutput( ACTIONS_ENABLED_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ACTIONS_ENABLED_FB__AnalogSerialOutput__, ACTIONS_ENABLED_FB );
    
    THUMBSUP_ENABLED_FB = new Crestron.Logos.SplusObjects.AnalogOutput( THUMBSUP_ENABLED_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( THUMBSUP_ENABLED_FB__AnalogSerialOutput__, THUMBSUP_ENABLED_FB );
    
    THUMBSDOWN_ENABLED_FB = new Crestron.Logos.SplusObjects.AnalogOutput( THUMBSDOWN_ENABLED_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( THUMBSDOWN_ENABLED_FB__AnalogSerialOutput__, THUMBSDOWN_ENABLED_FB );
    
    CHAPTERS_ENABLED_FB = new Crestron.Logos.SplusObjects.AnalogOutput( CHAPTERS_ENABLED_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CHAPTERS_ENABLED_FB__AnalogSerialOutput__, CHAPTERS_ENABLED_FB );
    
    DIALOG_BUTTONS = new Crestron.Logos.SplusObjects.AnalogOutput( DIALOG_BUTTONS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( DIALOG_BUTTONS__AnalogSerialOutput__, DIALOG_BUTTONS );
    
    SHUFFLE_FB = new Crestron.Logos.SplusObjects.AnalogOutput( SHUFFLE_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SHUFFLE_FB__AnalogSerialOutput__, SHUFFLE_FB );
    
    REPEAT_FB = new Crestron.Logos.SplusObjects.AnalogOutput( REPEAT_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( REPEAT_FB__AnalogSerialOutput__, REPEAT_FB );
    
    SCROLLBAR_FB = new Crestron.Logos.SplusObjects.AnalogOutput( SCROLLBAR_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SCROLLBAR_FB__AnalogSerialOutput__, SCROLLBAR_FB );
    
    RECORD_FB = new Crestron.Logos.SplusObjects.AnalogOutput( RECORD_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RECORD_FB__AnalogSerialOutput__, RECORD_FB );
    
    BACK_ENABLE = new Crestron.Logos.SplusObjects.AnalogOutput( BACK_ENABLE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BACK_ENABLE__AnalogSerialOutput__, BACK_ENABLE );
    
    PREV_ENABLE = new Crestron.Logos.SplusObjects.AnalogOutput( PREV_ENABLE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PREV_ENABLE__AnalogSerialOutput__, PREV_ENABLE );
    
    NEXT_ENABLE = new Crestron.Logos.SplusObjects.AnalogOutput( NEXT_ENABLE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NEXT_ENABLE__AnalogSerialOutput__, NEXT_ENABLE );
    
    SCROLL_ENABLE = new Crestron.Logos.SplusObjects.AnalogOutput( SCROLL_ENABLE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SCROLL_ENABLE__AnalogSerialOutput__, SCROLL_ENABLE );
    
    CURRENT_MEDIA_TYPE = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_MEDIA_TYPE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_MEDIA_TYPE__AnalogSerialOutput__, CURRENT_MEDIA_TYPE );
    
    CURRENT_TRACK_PROGRESS = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_TRACK_PROGRESS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_TRACK_PROGRESS__AnalogSerialOutput__, CURRENT_TRACK_PROGRESS );
    
    CURRENT_PLAY_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_PLAY_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_PLAY_STATE__AnalogSerialOutput__, CURRENT_PLAY_STATE );
    
    VOLUME_FB = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME_FB__AnalogSerialOutput__, VOLUME_FB );
    
    MUTE_FB = new Crestron.Logos.SplusObjects.AnalogOutput( MUTE_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MUTE_FB__AnalogSerialOutput__, MUTE_FB );
    
    BROWSE_ART_FORMAT = new Crestron.Logos.SplusObjects.AnalogOutput( BROWSE_ART_FORMAT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BROWSE_ART_FORMAT__AnalogSerialOutput__, BROWSE_ART_FORMAT );
    
    CONFIGURAITON_FB = new Crestron.Logos.SplusObjects.AnalogOutput( CONFIGURAITON_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONFIGURAITON_FB__AnalogSerialOutput__, CONFIGURAITON_FB );
    
    BUTTON_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( BUTTON_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BUTTON_STATE__AnalogSerialOutput__, BUTTON_STATE );
    
    ALPHA_VAL_INIT = new Crestron.Logos.SplusObjects.AnalogOutput( ALPHA_VAL_INIT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ALPHA_VAL_INIT__AnalogSerialOutput__, ALPHA_VAL_INIT );
    
    SERVICE_LOGO_FB = new Crestron.Logos.SplusObjects.AnalogOutput( SERVICE_LOGO_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SERVICE_LOGO_FB__AnalogSerialOutput__, SERVICE_LOGO_FB );
    
    STARS_FB = new Crestron.Logos.SplusObjects.AnalogOutput( STARS_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( STARS_FB__AnalogSerialOutput__, STARS_FB );
    
    SCROBBLE_FB = new Crestron.Logos.SplusObjects.AnalogOutput( SCROBBLE_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SCROBBLE_FB__AnalogSerialOutput__, SCROBBLE_FB );
    
    TITLE_ENABLED = new InOutArray<AnalogOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        TITLE_ENABLED[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( TITLE_ENABLED__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( TITLE_ENABLED__AnalogSerialOutput__ + i, TITLE_ENABLED[i+1] );
    }
    
    COMMAND__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( COMMAND__DOLLAR____AnalogSerialInput__, 256, this );
    m_StringInputList.Add( COMMAND__DOLLAR____AnalogSerialInput__, COMMAND__DOLLAR__ );
    
    INSTANCE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( INSTANCE__DOLLAR____AnalogSerialInput__, 64, this );
    m_StringInputList.Add( INSTANCE__DOLLAR____AnalogSerialInput__, INSTANCE__DOLLAR__ );
    
    SERVICE = new Crestron.Logos.SplusObjects.StringInput( SERVICE__AnalogSerialInput__, 64, this );
    m_StringInputList.Add( SERVICE__AnalogSerialInput__, SERVICE );
    
    TIMESTAMP__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( TIMESTAMP__DOLLAR____AnalogSerialInput__, 18, this );
    m_StringInputList.Add( TIMESTAMP__DOLLAR____AnalogSerialInput__, TIMESTAMP__DOLLAR__ );
    
    IP_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IP_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IP_TX__DOLLAR____AnalogSerialOutput__, IP_TX__DOLLAR__ );
    
    CAPTION = new Crestron.Logos.SplusObjects.StringOutput( CAPTION__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CAPTION__AnalogSerialOutput__, CAPTION );
    
    IP_STATUS = new Crestron.Logos.SplusObjects.StringOutput( IP_STATUS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IP_STATUS__AnalogSerialOutput__, IP_STATUS );
    
    LIST_POSITION = new Crestron.Logos.SplusObjects.StringOutput( LIST_POSITION__AnalogSerialOutput__, this );
    m_StringOutputList.Add( LIST_POSITION__AnalogSerialOutput__, LIST_POSITION );
    
    METADATA1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( METADATA1__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( METADATA1__DOLLAR____AnalogSerialOutput__, METADATA1__DOLLAR__ );
    
    METADATA2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( METADATA2__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( METADATA2__DOLLAR____AnalogSerialOutput__, METADATA2__DOLLAR__ );
    
    METADATA3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( METADATA3__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( METADATA3__DOLLAR____AnalogSerialOutput__, METADATA3__DOLLAR__ );
    
    METADATA4__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( METADATA4__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( METADATA4__DOLLAR____AnalogSerialOutput__, METADATA4__DOLLAR__ );
    
    METALABEL1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( METALABEL1__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( METALABEL1__DOLLAR____AnalogSerialOutput__, METALABEL1__DOLLAR__ );
    
    METALABEL2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( METALABEL2__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( METALABEL2__DOLLAR____AnalogSerialOutput__, METALABEL2__DOLLAR__ );
    
    METALABEL3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( METALABEL3__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( METALABEL3__DOLLAR____AnalogSerialOutput__, METALABEL3__DOLLAR__ );
    
    METALABEL4__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( METALABEL4__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( METALABEL4__DOLLAR____AnalogSerialOutput__, METALABEL4__DOLLAR__ );
    
    TRACKLEN_FB = new Crestron.Logos.SplusObjects.StringOutput( TRACKLEN_FB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TRACKLEN_FB__AnalogSerialOutput__, TRACKLEN_FB );
    
    TRACKTIME_FB = new Crestron.Logos.SplusObjects.StringOutput( TRACKTIME_FB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TRACKTIME_FB__AnalogSerialOutput__, TRACKTIME_FB );
    
    TRACKTIME_SECONDS_FB = new Crestron.Logos.SplusObjects.StringOutput( TRACKTIME_SECONDS_FB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TRACKTIME_SECONDS_FB__AnalogSerialOutput__, TRACKTIME_SECONDS_FB );
    
    NOWPLAYING_ART__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYING_ART__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOWPLAYING_ART__DOLLAR____AnalogSerialOutput__, NOWPLAYING_ART__DOLLAR__ );
    
    NOWPLAYING_ART_SMALL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYING_ART_SMALL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOWPLAYING_ART_SMALL__DOLLAR____AnalogSerialOutput__, NOWPLAYING_ART_SMALL__DOLLAR__ );
    
    NOWPLAYING_THUMB__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYING_THUMB__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOWPLAYING_THUMB__DOLLAR____AnalogSerialOutput__, NOWPLAYING_THUMB__DOLLAR__ );
    
    NOWPLAYING_THUMB_FULL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NOWPLAYING_THUMB_FULL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOWPLAYING_THUMB_FULL__DOLLAR____AnalogSerialOutput__, NOWPLAYING_THUMB_FULL__DOLLAR__ );
    
    BROWSE_ART__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( BROWSE_ART__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( BROWSE_ART__DOLLAR____AnalogSerialOutput__, BROWSE_ART__DOLLAR__ );
    
    PLAYING_TRACK_NUMBER = new Crestron.Logos.SplusObjects.StringOutput( PLAYING_TRACK_NUMBER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PLAYING_TRACK_NUMBER__AnalogSerialOutput__, PLAYING_TRACK_NUMBER );
    
    MEDIAINFO1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MEDIAINFO1__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MEDIAINFO1__DOLLAR____AnalogSerialOutput__, MEDIAINFO1__DOLLAR__ );
    
    MEDIAINFO2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MEDIAINFO2__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MEDIAINFO2__DOLLAR____AnalogSerialOutput__, MEDIAINFO2__DOLLAR__ );
    
    MEDIAINFO3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MEDIAINFO3__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MEDIAINFO3__DOLLAR____AnalogSerialOutput__, MEDIAINFO3__DOLLAR__ );
    
    MEDIAINFO4__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MEDIAINFO4__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MEDIAINFO4__DOLLAR____AnalogSerialOutput__, MEDIAINFO4__DOLLAR__ );
    
    MEDIAINFO5__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MEDIAINFO5__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MEDIAINFO5__DOLLAR____AnalogSerialOutput__, MEDIAINFO5__DOLLAR__ );
    
    MEDIAINFO6__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MEDIAINFO6__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MEDIAINFO6__DOLLAR____AnalogSerialOutput__, MEDIAINFO6__DOLLAR__ );
    
    MEDIAINFO7__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MEDIAINFO7__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MEDIAINFO7__DOLLAR____AnalogSerialOutput__, MEDIAINFO7__DOLLAR__ );
    
    MESSAGECAPTION__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGECAPTION__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGECAPTION__DOLLAR____AnalogSerialOutput__, MESSAGECAPTION__DOLLAR__ );
    
    MESSAGETEXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGETEXT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGETEXT__DOLLAR____AnalogSerialOutput__, MESSAGETEXT__DOLLAR__ );
    
    MESSAGEVALUE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGEVALUE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGEVALUE__DOLLAR____AnalogSerialOutput__, MESSAGEVALUE__DOLLAR__ );
    
    CONTEXT_BUTTON_1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONTEXT_BUTTON_1__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONTEXT_BUTTON_1__DOLLAR____AnalogSerialOutput__, CONTEXT_BUTTON_1__DOLLAR__ );
    
    CONTEXT_BUTTON_2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONTEXT_BUTTON_2__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONTEXT_BUTTON_2__DOLLAR____AnalogSerialOutput__, CONTEXT_BUTTON_2__DOLLAR__ );
    
    CONTEXT_BUTTON_3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONTEXT_BUTTON_3__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONTEXT_BUTTON_3__DOLLAR____AnalogSerialOutput__, CONTEXT_BUTTON_3__DOLLAR__ );
    
    CONTEXT_BUTTON_4__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONTEXT_BUTTON_4__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONTEXT_BUTTON_4__DOLLAR____AnalogSerialOutput__, CONTEXT_BUTTON_4__DOLLAR__ );
    
    BUTTONTEXT = new InOutArray<StringOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        BUTTONTEXT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( BUTTONTEXT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( BUTTONTEXT__AnalogSerialOutput__ + i, BUTTONTEXT[i+1] );
    }
    
    LISTITEM__DOLLAR__ = new InOutArray<StringOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        LISTITEM__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( LISTITEM__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( LISTITEM__DOLLAR____AnalogSerialOutput__ + i, LISTITEM__DOLLAR__[i+1] );
    }
    
    LISTSUBTEXT__DOLLAR__ = new InOutArray<StringOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        LISTSUBTEXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( LISTSUBTEXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( LISTSUBTEXT__DOLLAR____AnalogSerialOutput__ + i, LISTSUBTEXT__DOLLAR__[i+1] );
    }
    
    LISTART__DOLLAR__ = new InOutArray<StringOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        LISTART__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( LISTART__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( LISTART__DOLLAR____AnalogSerialOutput__ + i, LISTART__DOLLAR__[i+1] );
    }
    
    IP_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( IP_RX__DOLLAR____AnalogSerialInput__, 16000, this );
    m_StringInputList.Add( IP_RX__DOLLAR____AnalogSerialInput__, IP_RX__DOLLAR__ );
    
    ARTSTYLE = new UShortParameter( ARTSTYLE__Parameter__, this );
    m_ParameterList.Add( ARTSTYLE__Parameter__, ARTSTYLE );
    
    SEEK_DELTA = new UShortParameter( SEEK_DELTA__Parameter__, this );
    m_ParameterList.Add( SEEK_DELTA__Parameter__, SEEK_DELTA );
    
    MESSAGEBOXDISPLAY_Callback = new WaitFunction( MESSAGEBOXDISPLAY_CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_0___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_0___CallbackFn );
    
    CONTEXTBUTTON1.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONTEXTBUTTON1_OnPush_0, false ) );
    CONTEXTBUTTON2.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONTEXTBUTTON2_OnPush_1, false ) );
    CONTEXTBUTTON3.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONTEXTBUTTON3_OnPush_2, false ) );
    CONTEXTBUTTON4.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONTEXTBUTTON4_OnPush_3, false ) );
    SEEK_FORWARD.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEEK_FORWARD_OnPush_4, false ) );
    SEEK_BACK.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEEK_BACK_OnPush_5, false ) );
    ACTIONS.OnDigitalPush.Add( new InputChangeHandlerWrapper( ACTIONS_OnPush_6, false ) );
    ZONES.OnDigitalPush.Add( new InputChangeHandlerWrapper( ZONES_OnPush_7, false ) );
    SAVEPLAYLIST.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVEPLAYLIST_OnPush_8, false ) );
    CLEARQUEUE.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEARQUEUE_OnPush_9, false ) );
    SEARCH.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEARCH_OnPush_10, false ) );
    GO_BACK.OnDigitalPush.Add( new InputChangeHandlerWrapper( GO_BACK_OnPush_11, false ) );
    for( uint i = 0; i < 10; i++ )
        ART_ERROR[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( ART_ERROR_OnChange_12, false ) );
        
    COMMAND__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( COMMAND__DOLLAR___OnChange_13, false ) );
    CONNECT.OnDigitalChange.Add( new InputChangeHandlerWrapper( CONNECT_OnChange_14, false ) );
    for( uint i = 0; i < 3; i++ )
        DIALOG_BUTTON[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( DIALOG_BUTTON_OnPush_15, false ) );
        
    DIRECT_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( DIRECT_VOLUME_OnChange_16, false ) );
    EVENTS_ENABLED.OnDigitalChange.Add( new InputChangeHandlerWrapper( EVENTS_ENABLED_OnChange_17, false ) );
    IP_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( IP_RX__DOLLAR___OnChange_18, false ) );
    LISTITEMSCOUNT.OnAnalogChange.Add( new InputChangeHandlerWrapper( LISTITEMSCOUNT_OnChange_19, false ) );
    PAGE_FB.OnAnalogChange.Add( new InputChangeHandlerWrapper( PAGE_FB_OnChange_20, false ) );
    THUMBNAILSCOUNT.OnAnalogChange.Add( new InputChangeHandlerWrapper( THUMBNAILSCOUNT_OnChange_21, false ) );
    SERVICE.OnSerialChange.Add( new InputChangeHandlerWrapper( SERVICE_OnChange_22, false ) );
    SCROLLBAR_POSITION.OnAnalogChange.Add( new InputChangeHandlerWrapper( SCROLLBAR_POSITION_OnChange_23, false ) );
    NEXTPAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( NEXTPAGE_OnPush_24, false ) );
    PREVPAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PREVPAGE_OnPush_25, false ) );
    LIST_ADDTOQUEUE.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIST_ADDTOQUEUE_OnPush_26, false ) );
    LIST_PLAYNOW.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIST_PLAYNOW_OnPush_27, false ) );
    THUMBSDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( THUMBSDOWN_OnPush_28, false ) );
    THUMBSUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( THUMBSUP_OnPush_29, false ) );
    HOME.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOME_OnPush_30, false ) );
    END.OnDigitalPush.Add( new InputChangeHandlerWrapper( END_OnPush_31, false ) );
    for( uint i = 0; i < 10; i++ )
        TITLE_ADDTOPLAYLIST[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( TITLE_ADDTOPLAYLIST_OnPush_32, false ) );
        
    for( uint i = 0; i < 10; i++ )
        TITLE_PLAYNOW[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( TITLE_PLAYNOW_OnPush_33, false ) );
        
    for( uint i = 0; i < 10; i++ )
        TITLE_SELECT[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( TITLE_SELECT_OnPush_34, false ) );
        
    SETOSD.OnDigitalPush.Add( new InputChangeHandlerWrapper( SETOSD_OnPush_35, false ) );
    FROM_IP_CLIENT_STATUS.OnAnalogChange.Add( new InputChangeHandlerWrapper( FROM_IP_CLIENT_STATUS_OnChange_36, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_AUTONOMIC_MMS_IP_PROCESSOR_V3_2_5 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction MESSAGEBOXDISPLAY_Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_0___Callback;


const uint PREVPAGE__DigitalInput__ = 0;
const uint NEXTPAGE__DigitalInput__ = 1;
const uint HOME__DigitalInput__ = 2;
const uint END__DigitalInput__ = 3;
const uint CONNECT__DigitalInput__ = 4;
const uint EVENTS_ENABLED__DigitalInput__ = 5;
const uint GO_BACK__DigitalInput__ = 6;
const uint LIST_ADDTOQUEUE__DigitalInput__ = 7;
const uint LIST_PLAYNOW__DigitalInput__ = 8;
const uint THUMBSUP__DigitalInput__ = 9;
const uint THUMBSDOWN__DigitalInput__ = 10;
const uint DEBUG__DigitalInput__ = 11;
const uint SETOSD__DigitalInput__ = 12;
const uint CONTEXTBUTTON1__DigitalInput__ = 13;
const uint CONTEXTBUTTON2__DigitalInput__ = 14;
const uint CONTEXTBUTTON3__DigitalInput__ = 15;
const uint CONTEXTBUTTON4__DigitalInput__ = 16;
const uint ACTIONS__DigitalInput__ = 17;
const uint SAVEPLAYLIST__DigitalInput__ = 18;
const uint SEARCH__DigitalInput__ = 19;
const uint CLEARQUEUE__DigitalInput__ = 20;
const uint ZONES__DigitalInput__ = 21;
const uint SEEK_BACK__DigitalInput__ = 22;
const uint SEEK_FORWARD__DigitalInput__ = 23;
const uint LISTITEMSCOUNT__AnalogSerialInput__ = 0;
const uint THUMBNAILSCOUNT__AnalogSerialInput__ = 1;
const uint FROM_IP_CLIENT_STATUS__AnalogSerialInput__ = 2;
const uint SCROLLBAR_POSITION__AnalogSerialInput__ = 3;
const uint PAGE_FB__AnalogSerialInput__ = 4;
const uint DIRECT_VOLUME__AnalogSerialInput__ = 5;
const uint NOWPLAYING_ART_HEIGHT__AnalogSerialInput__ = 6;
const uint NOWPLAYING_ART_WIDTH__AnalogSerialInput__ = 7;
const uint COMMAND__DOLLAR____AnalogSerialInput__ = 8;
const uint INSTANCE__DOLLAR____AnalogSerialInput__ = 9;
const uint SERVICE__AnalogSerialInput__ = 10;
const uint IP_RX__DOLLAR____AnalogSerialInput__ = 11;
const uint TIMESTAMP__DOLLAR____AnalogSerialInput__ = 12;
const uint ART_ERROR__AnalogSerialInput__ = 13;
const uint DIALOG_BUTTON__DigitalInput__ = 24;
const uint TITLE_SELECT__DigitalInput__ = 27;
const uint TITLE_ADDTOPLAYLIST__DigitalInput__ = 37;
const uint TITLE_PLAYNOW__DigitalInput__ = 47;
const uint TO_IP_CONNECT__DigitalOutput__ = 0;
const uint PAGE_HOME_FB__DigitalOutput__ = 1;
const uint PAGE_DETAILS_FB__DigitalOutput__ = 2;
const uint PAGE_NOWPLAYING_FB__DigitalOutput__ = 3;
const uint PAGE_THUMBNAILS_FB__DigitalOutput__ = 4;
const uint PAGE_LIST_FB__DigitalOutput__ = 5;
const uint PAGE_MOVIE_FB__DigitalOutput__ = 6;
const uint PAGE_MESSAGE_FB__DigitalOutput__ = 7;
const uint PAGE_SYNOPSIS_FB__DigitalOutput__ = 8;
const uint PAGE_CHAPTERS_FB__DigitalOutput__ = 9;
const uint PAGE_KB_FB__DigitalOutput__ = 10;
const uint REFRESH__DigitalOutput__ = 11;
const uint SEARCH_ENABLED_FB__DigitalOutput__ = 12;
const uint DIALOG_ENABLED_FB__DigitalOutput__ = 13;
const uint ALPHA_ENABLED_FB__DigitalOutput__ = 14;
const uint ACTIONS_ENABLED_FB__AnalogSerialOutput__ = 0;
const uint THUMBSUP_ENABLED_FB__AnalogSerialOutput__ = 1;
const uint THUMBSDOWN_ENABLED_FB__AnalogSerialOutput__ = 2;
const uint CHAPTERS_ENABLED_FB__AnalogSerialOutput__ = 3;
const uint DIALOG_BUTTONS__AnalogSerialOutput__ = 4;
const uint SHUFFLE_FB__AnalogSerialOutput__ = 5;
const uint REPEAT_FB__AnalogSerialOutput__ = 6;
const uint SCROLLBAR_FB__AnalogSerialOutput__ = 7;
const uint RECORD_FB__AnalogSerialOutput__ = 8;
const uint BACK_ENABLE__AnalogSerialOutput__ = 9;
const uint PREV_ENABLE__AnalogSerialOutput__ = 10;
const uint NEXT_ENABLE__AnalogSerialOutput__ = 11;
const uint SCROLL_ENABLE__AnalogSerialOutput__ = 12;
const uint CURRENT_MEDIA_TYPE__AnalogSerialOutput__ = 13;
const uint CURRENT_TRACK_PROGRESS__AnalogSerialOutput__ = 14;
const uint CURRENT_PLAY_STATE__AnalogSerialOutput__ = 15;
const uint VOLUME_FB__AnalogSerialOutput__ = 16;
const uint MUTE_FB__AnalogSerialOutput__ = 17;
const uint BROWSE_ART_FORMAT__AnalogSerialOutput__ = 18;
const uint CONFIGURAITON_FB__AnalogSerialOutput__ = 19;
const uint BUTTON_STATE__AnalogSerialOutput__ = 20;
const uint ALPHA_VAL_INIT__AnalogSerialOutput__ = 21;
const uint SERVICE_LOGO_FB__AnalogSerialOutput__ = 22;
const uint STARS_FB__AnalogSerialOutput__ = 23;
const uint SCROBBLE_FB__AnalogSerialOutput__ = 24;
const uint IP_TX__DOLLAR____AnalogSerialOutput__ = 25;
const uint CAPTION__AnalogSerialOutput__ = 26;
const uint IP_STATUS__AnalogSerialOutput__ = 27;
const uint LIST_POSITION__AnalogSerialOutput__ = 28;
const uint METADATA1__DOLLAR____AnalogSerialOutput__ = 29;
const uint METADATA2__DOLLAR____AnalogSerialOutput__ = 30;
const uint METADATA3__DOLLAR____AnalogSerialOutput__ = 31;
const uint METADATA4__DOLLAR____AnalogSerialOutput__ = 32;
const uint METALABEL1__DOLLAR____AnalogSerialOutput__ = 33;
const uint METALABEL2__DOLLAR____AnalogSerialOutput__ = 34;
const uint METALABEL3__DOLLAR____AnalogSerialOutput__ = 35;
const uint METALABEL4__DOLLAR____AnalogSerialOutput__ = 36;
const uint TRACKLEN_FB__AnalogSerialOutput__ = 37;
const uint TRACKTIME_FB__AnalogSerialOutput__ = 38;
const uint TRACKTIME_SECONDS_FB__AnalogSerialOutput__ = 39;
const uint NOWPLAYING_ART__DOLLAR____AnalogSerialOutput__ = 40;
const uint NOWPLAYING_ART_SMALL__DOLLAR____AnalogSerialOutput__ = 41;
const uint NOWPLAYING_THUMB__DOLLAR____AnalogSerialOutput__ = 42;
const uint NOWPLAYING_THUMB_FULL__DOLLAR____AnalogSerialOutput__ = 43;
const uint BROWSE_ART__DOLLAR____AnalogSerialOutput__ = 44;
const uint PLAYING_TRACK_NUMBER__AnalogSerialOutput__ = 45;
const uint MEDIAINFO1__DOLLAR____AnalogSerialOutput__ = 46;
const uint MEDIAINFO2__DOLLAR____AnalogSerialOutput__ = 47;
const uint MEDIAINFO3__DOLLAR____AnalogSerialOutput__ = 48;
const uint MEDIAINFO4__DOLLAR____AnalogSerialOutput__ = 49;
const uint MEDIAINFO5__DOLLAR____AnalogSerialOutput__ = 50;
const uint MEDIAINFO6__DOLLAR____AnalogSerialOutput__ = 51;
const uint MEDIAINFO7__DOLLAR____AnalogSerialOutput__ = 52;
const uint MESSAGECAPTION__DOLLAR____AnalogSerialOutput__ = 53;
const uint MESSAGETEXT__DOLLAR____AnalogSerialOutput__ = 54;
const uint MESSAGEVALUE__DOLLAR____AnalogSerialOutput__ = 55;
const uint CONTEXT_BUTTON_1__DOLLAR____AnalogSerialOutput__ = 56;
const uint CONTEXT_BUTTON_2__DOLLAR____AnalogSerialOutput__ = 57;
const uint CONTEXT_BUTTON_3__DOLLAR____AnalogSerialOutput__ = 58;
const uint CONTEXT_BUTTON_4__DOLLAR____AnalogSerialOutput__ = 59;
const uint TITLE_ENABLED__AnalogSerialOutput__ = 60;
const uint BUTTONTEXT__AnalogSerialOutput__ = 70;
const uint LISTITEM__DOLLAR____AnalogSerialOutput__ = 73;
const uint LISTSUBTEXT__DOLLAR____AnalogSerialOutput__ = 83;
const uint LISTART__DOLLAR____AnalogSerialOutput__ = 93;
const uint ARTSTYLE__Parameter__ = 10;
const uint SEEK_DELTA__Parameter__ = 11;

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

[SplusStructAttribute(-1, true, false)]
public class STRUCT_HISTORY : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  COMMAND;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  FILTERS;
    
    [SplusStructAttribute(2, false, false)]
    public CrestronString  DESCRIPTION;
    
    [SplusStructAttribute(3, false, false)]
    public ushort  CONTEXT = 0;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  PAGE = 0;
    
    
    public STRUCT_HISTORY( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        COMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, Owner );
        FILTERS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1024, Owner );
        DESCRIPTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, Owner );
        
        
    }
    
}

}
