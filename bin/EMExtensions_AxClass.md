   #EFDocSignXmlDocument_BR_EMExtension��g5    >  EMLabelController��g5>  T  EMLabelContract��g5�  �   EMLabelTest��g5j  o   EMLabelService��g5�  �   � ! Oclass EFDocSignXmlDocument_BR_EMExtension extends EFDocSignXmlDocument_BR
{
}EFDocSignXmlDocument_BR   � 
signDocumentWithId   � _keyVaultCertificateRef KeyVaultCertificateRef�� _certificateSubject DigitalCertificateSubject�� _xmlDoc 
XmlElement�� _elementToBeSignedName  ��   � �� 	
	construct�  #EFDocSignXmlDocument_BR_EMExtension� �� 	

upgradeCsp   � _currentKey 0System.Security.Cryptography.AsymmetricAlgorithm��  0System.Security.Cryptography.AsymmetricAlgorithm��#EFDocSignXmlDocument_BR_EMExtension�� ! �/// <summary>
/// Label controller, responsible for calling the label handler class
/// </summary>
internal final class EMLabelController extends SysOperationServiceController
{
}SysOperationServiceController   � 	
	construct�  EMLabelController� �� 	
main   � _args Args��  � �EMLabelController�� !     DataContract��/// <summary>
/// Label contract, responsible for defining the criteria of the operation
/// </summary>
[DataContract]
internal final class EMLabelContract
{
}EMLabelContract�� ! &internal final class EMLabelTest
{
}   � 	
main   � _args Args��  � �EMLabelTest�� ! �/// <summary>
/// Label service, responsible for handling the labels
/// </summary>
internal final class EMLabelService
{
}   � 
run   � 	_contract EMLabelContract��  � �EMLabelService�