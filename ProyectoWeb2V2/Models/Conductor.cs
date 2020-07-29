using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

using Firebase.Auth;
using Firebase.Database.Query;
using Firebase.Storage;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ProyectoWeb2V2.Models
{
    public class Conductor
    {
        public string id_conductor { get; set; }
        public string dni_conductor { get; set; }
        public string nombres_conductor { get; set; }
        public string apellido_conductor { get; set; }
        public string correo_conductor { get; set; }
       
        public string clave_conductor { get; set; }
       
        public string rutafoto_conductor { get; set; }
        public double lat_conductor { get; set; }
        public double lon_conductor { get; set; }
        public string fecha_creacion { get; set; }


        private  Conexion conexion;
        private  IFirebaseClient client;
        private  string Bucket = "fir-app-cf755.appspot.com";


        public async Task<bool> Upload(FileStream stream, Conductor obj, string filenanme)
        {

            conexion = new Conexion();
            var auth = new FirebaseAuthProvider(new FirebaseConfig(conexion.Firekey()));
            var a = await auth.SignInWithEmailAndPasswordAsync(conexion.AthEmail(), conexion.AthPassword());

            var cancellation = new CancellationTokenSource();
            var task = new FirebaseStorage(
                Bucket,
                new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                    ThrowOnCancel = true // when you cancel the upload, exception is thrown. By default no exception is thrown
                })
                .Child("FotosConductores")
                .Child(filenanme)
                .PutAsync(stream, cancellation.Token);
            try
            {
                string link = await task;
                obj.rutafoto_conductor = link;
                Task tarea2 = Task.Run(() => Create_Conductor(obj));
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception was thrown: {0}", ex);
            }
            return true;
        }

        public async Task<bool> Create_Conductor(Conductor o)
        {
            try
            {
                conexion = new Conexion();
                var auth = new FirebaseAuthProvider(new FirebaseConfig(conexion.Firekey()));
                var a = await auth.CreateUserWithEmailAndPasswordAsync(o.correo_conductor, o.clave_conductor, o.nombres_conductor, true);

                var id = a.User.LocalId;  //para tener el id del usuario que esta registrado we :V
                client = new FireSharp.FirebaseClient(conexion.conec());
                var data = o;

             //   PushResponse response = client.Push("Conductores/", data);
                data.id_conductor = id;
                SetResponse setResponse = client.Set("Conductores/" + data.id_conductor, data);
             //   ModelState.AddModelError(string.Empty, "verifica tu coreo" + "ids" + id);
                //  AddsUsuarios(o, id);

            }
            catch (Exception ex)
            {

               // ModelState.AddModelError(string.Empty, ex.Message);

            }
            return true; 
        }


    }
}