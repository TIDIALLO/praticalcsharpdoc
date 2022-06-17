
var assetDataFileReaderWriter = new FileReaderWriter<AssetData>();
assetDataFileReaderWriter.Initialize();

assetDataFileReaderWriter.Write(new AssetData
{ DataId = 2, DataDescription = "Some description.", AssetId = 5, AssetName = "Asset 5."});

var asset5 = assetDataFileReaderWriter.Read(2);