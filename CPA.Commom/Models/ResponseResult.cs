namespace CPA.Commom.Models {
    public class ResponseResult<Model> {

        public bool Success { get; set; }
        public string Message { get; set; } = "";
        public Model? Data { get; set; }

        public ResponseResult(bool success, string message) {
            this.Success = success;
            this.Message = message;
        }

        public ResponseResult(bool success, string message, Model? data) {
            this.Success = success;
            this.Message = message;
            this.Data = data;
        }

    }
}
