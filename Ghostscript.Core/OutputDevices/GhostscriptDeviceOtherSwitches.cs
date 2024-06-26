﻿/* GhostscriptDeviceOtherSwitches.cs
 * This file is part of Iterad.Ghostscript.NET which is released under AGPL3.
 * See file COPYRIGHT.md or go to https://github.com/Iterad-Science/Iterad.Ghostscript.NET for full copyright information.
 * See file LICENSE.md or go to http://www.gnu.org/licenses/ for full license details.
 */

using System;

namespace Ghostscript.NET
{
    public class GhostscriptDeviceOtherSwitches
    {
        #region DelayBind

        /// <summary>
        /// Causes bind to remember all its invocations, but not actually execute them until the .bindnow procedure is 
        /// called. Useful only for certain specialized packages like pstotext that redefine operators. See the documentation
        /// for .bindnow for more information on using this feature.
        /// </summary>
        [GhostscriptSwitch("-dDELAYBIND")]
        public GhostscriptOptionalSwitch? DelayBind { get; set; }

        #endregion

        #region DoPdfMarks

        /// <summary>
        /// Causes pdfmark to be called for bookmarks, annotations, links and cropbox when processing PDF files. Normally, 
        /// pdfmark is only called for these types for PostScript files or when the output device requests it (e.g. pdfwrite device).
        /// </summary>
        [GhostscriptSwitch("-dDOPDFMARKS")]
        public GhostscriptOptionalSwitch? DoPdfMarks { get; set; }

        #endregion

        #region NoBind

        /// <summary>
        /// Disables the bind operator. Useful only for debugging.
        /// </summary>
        [GhostscriptSwitch("-dNOBIND")]
        public GhostscriptOptionalSwitch? NoBind { get; set; }

        #endregion

        #region NoCache

        /// <summary>
        /// Disables character caching. Useful only for debugging.
        /// </summary>
        [GhostscriptSwitch("-dNOCACHE")]
        public GhostscriptOptionalSwitch? NoCache { get; set; }

        #endregion

        #region NoGC

        /// <summary>
        /// Suppresses the initial automatic enabling of the garbage collector in Level 2 systems. 
        /// (The vmreclaim operator is not disabled.) Useful only for debugging.
        /// </summary>
        [GhostscriptSwitch("-dNOGC")]
        public GhostscriptOptionalSwitch? NoGC { get; set; }

        #endregion

        #region NoOuterSave

        /// <summary>
        /// Suppresses the initial save that is used for compatibility with Adobe PS Interpreters that ordinarily 
        /// run under a job server. If a job server is going to be used to set up the outermost save level, then 
        /// -dNOOUTERSAVE should be used so that the restore between jobs will restore global VM as expected.
        /// </summary>
        [GhostscriptSwitch("-dNOOUTERSAVE")]
        public GhostscriptOptionalSwitch? NoOuterSave { get; set; }

        #endregion

        #region NoSafer

        /// <summary>
        /// (equivalent to -dDELAYSAFER). 
        /// This flag disables SAFER mode until the .setsafe procedure is run. This is intended for clients or scripts 
        /// that cannot operate in SAFER mode. If Ghostscript is started with -dNOSAFER or -dDELAYSAFER, PostScript 
        /// programs are allowed to read, write, rename or delete any files in the system that are not protected by 
        /// operating system permissions. This mode should be used with caution, and .setsafe should be run prior to 
        /// running any PostScript file with unknown contents.
        /// </summary>
        [GhostscriptSwitch("-dNOSAFER")]
        public GhostscriptOptionalSwitch? NoSafer { get; set; }

        #endregion

        #region Safer

        /// <summary>
        /// Disables the deletefile and renamefile operators, and the ability to open piped commands (%pipe%cmd) at all.
        /// Only %stdout and %stderr can be opened for writing. Disables reading of files other than %stdin, those given 
        /// as a command line argument, or those contained on one of the paths given by LIBPATH and FONTPATH and specified
        /// by the system params /FontResourceDir and /GenericResourceDir.
        /// This mode also sets the .LockSafetyParams parameter of the default device, or the device specified with the 
        /// -sDEVICE= switch to protect against programs that attempt to write to files using the OutputFile device parameter.
        /// Note that since the device parameters specified on the command line (including OutputFile) are set prior to SAFER
        /// mode, the -sOutputFile=... on the command line is unrestricted.
        /// </summary>
        [GhostscriptSwitch("-dSAFER")]
        public GhostscriptOptionalSwitch? Safer { get; set; }

        #endregion

        #region Strict

        /// <summary>
        /// Disables as many Ghostscript extensions as feasible, to be more helpful in debugging applications that produce 
        /// output for Adobe and other RIPs.
        /// </summary>
        [GhostscriptSwitch("-dSTRICT")]
        public GhostscriptOptionalSwitch? Strict { get; set; }

        #endregion

        #region WriteSystemDict

        /// <summary>
        /// Leaves systemdict writable. This is necessary when running special utility programs such as font2c and pcharstr, 
        /// which must bypass normal PostScript access protection.
        /// </summary>
        [GhostscriptSwitch("-dWRITESYSTEMDICT")]
        public GhostscriptOptionalSwitch? WriteSystemDict { get; set; }

        #endregion
    }
}
