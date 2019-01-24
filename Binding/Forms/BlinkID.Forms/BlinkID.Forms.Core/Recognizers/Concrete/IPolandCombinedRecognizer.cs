﻿namespace Microblink.Forms.Core.Recognizers
{
    /// <summary>
    ///  Recognizer for combined reading of both front and back side of Polish ID.
    /// 
    /// </summary>
    public interface IPolandCombinedRecognizer : IRecognizer
    {
        
        /// <summary>
        /// Defines whether glare detector is enabled. 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool DetectGlare { get; set; }
        
        /// <summary>
        /// True if date of birth is being extracted from ID 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractDateOfBirth { get; set; }
        
        /// <summary>
        /// True if family name is being extracted from ID 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractFamilyName { get; set; }
        
        /// <summary>
        /// True if given names is being extracted from ID 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractGivenNames { get; set; }
        
        /// <summary>
        /// True if parents' given names is being extracted from ID 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractParentsGivenNames { get; set; }
        
        /// <summary>
        /// True if sex is being extracted from ID 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractSex { get; set; }
        
        /// <summary>
        /// True if surname is being extracted from ID 
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractSurname { get; set; }
        
        /// <summary>
        /// Defines whether face image will be available in result. 
        ///
        /// By default, this is set to 'false'
        /// </summary>
        bool ReturnFaceImage { get; set; }
        
        /// <summary>
        /// Defines whether full document image will be available in 
        ///
        /// By default, this is set to 'false'
        /// </summary>
        bool ReturnFullDocumentImage { get; set; }
        
        /// <summary>
        /// Defines whether or not recognition result should be signed. 
        ///
        /// By default, this is set to 'false'
        /// </summary>
        bool SignResult { get; set; }
        

        /// <summary>
        /// Gets the result.
        /// </summary>
        IPolandCombinedRecognizerResult Result { get; }
    }

    /// <summary>
    /// Result object for IPolandCombinedRecognizer.
    /// </summary>
    public interface IPolandCombinedRecognizerResult : IRecognizerResult {
        
        /// <summary>
        /// The date of birth of Polish ID owner. 
        /// </summary>
        IDate DateOfBirth { get; }
        
        /// <summary>
        /// The document date of expiry of the Polish ID. 
        /// </summary>
        IDate DateOfExpiry { get; }
        
        /// <summary>
        /// Defines digital signature of recognition results. 
        /// </summary>
        byte[] DigitalSignature { get; }
        
        /// <summary>
        /// Defines digital signature version. 
        /// </summary>
        uint DigitalSignatureVersion { get; }
        
        /// <summary>
        /// Defines {true} if data from scanned parts/sides of the document match, 
        /// </summary>
        bool DocumentDataMatch { get; }
        
        /// <summary>
        /// The document number of the Polish ID. 
        /// </summary>
        string DocumentNumber { get; }
        
        /// <summary>
        /// Face image from the document 
        /// </summary>
        Xamarin.Forms.ImageSource FaceImage { get; }
        
        /// <summary>
        /// The family name of the Polish ID owner. 
        /// </summary>
        string FamilyName { get; }
        
        /// <summary>
        /// Back side image of the document 
        /// </summary>
        Xamarin.Forms.ImageSource FullDocumentBackImage { get; }
        
        /// <summary>
        /// Front side image of the document 
        /// </summary>
        Xamarin.Forms.ImageSource FullDocumentFrontImage { get; }
        
        /// <summary>
        /// The given names of the Polish ID owner. 
        /// </summary>
        string GivenNames { get; }
        
        /// <summary>
        /// The issuer of the Polish ID. 
        /// </summary>
        string Issuer { get; }
        
        /// <summary>
        /// True if all check digits inside MRZ are correct, false otherwise. 
        /// </summary>
        bool MrzVerified { get; }
        
        /// <summary>
        /// The nationality of the Polish ID owner. 
        /// </summary>
        string Nationality { get; }
        
        /// <summary>
        /// The parents' given names of the Polish ID owner. 
        /// </summary>
        string ParentsGivenNames { get; }
        
        /// <summary>
        /// Personal number of the Polish ID owner. 
        /// </summary>
        string PersonalNumber { get; }
        
        /// <summary>
        /// {true} if recognizer has finished scanning first side and is now scanning back side, 
        /// </summary>
        bool ScanningFirstSideDone { get; }
        
        /// <summary>
        /// Sex of the Polish ID owner. 
        /// </summary>
        string Sex { get; }
        
        /// <summary>
        /// The surname of the Polish ID owner. 
        /// </summary>
        string Surname { get; }
        
    }
}