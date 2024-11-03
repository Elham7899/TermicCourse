namespace ErfanTermicCourse.ServiceResults;

public class ServiceResult
{

	public ServiceResult( string message)
	{
		Message = message;
	}



	public bool IsSuccess { get; set; }
	public string Message { get; set; }

	public static ServiceResult Ok(string message)
	{
		return new ServiceResult( message);
	}
	//public static ServiceResult Ok()
	//{
	//	return Ok("Operation Success");
	//}
	////public static ServiceResult Fail(string message, ApiResultStatusCode statusCode)
	////{
	////    return new ServiceResult(false, message, statusCode);
	////}

	//public static ServiceResult ServerError()
	//{
	//	return new ServiceResult(false, "Internal Server Error", ApiResultStatusCode.ServerError);
	//}

	//public static ServiceResult NotFound(string message)
	//{
	//	return new ServiceResult(false, message, ApiResultStatusCode.NotFound);
	//}
}
