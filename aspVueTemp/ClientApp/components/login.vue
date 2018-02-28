  <template>
    <div class="col-sm-4 col-sm-offset-4">
      <h2>Log In</h2>
      <p>Log in to your account to start saving.</p>
      <div class="alert alert-danger" v-if="error">
        <p>{{ error }}</p>
      </div>
      <div class="form-group">
        <input
          type="text"
          class="form-control"
          placeholder="Enter your username"
          v-model="credentials.email"
        >
      </div>
      <div class="form-group">
        <input
          type="password"
          class="form-control"
          placeholder="Enter your password"
          v-model="credentials.password"
        >
      </div>
        <div class="form-group">
        <input
        id ="rmbr"
          type="checkbox"
          class="form-control"
          v-model="credentials.remember"
        ><label for='rmbr'>Remeember me?</label>
      </div>
      <button class="btn btn-primary" @click="submit()">Access</button>
    </div>
  </template>

  <script>
 
  export default {
    data:{
     
        // We need to initialize the component with any
        // properties that will be used in it
        credentials :{
          email: '',
          password: '',
          remember: false,
        },
        solution:[],
    },
    methods: {
     onComplete: function() {
        var credentials = {
          email: this.credentials.email,
          password: this.credentials.password,
          remember: this.credentials.remember
        }

        // We need to pass the component's this context
        // to properly make use of http in the auth service
       
            let send = this.$http.post('/TokenAPI/Login', this.credentials)
            .then(response =>{
              this.solution = response.data;
              console.log(this.solution);
            });    
           // let response = await this.$http.get('/account/Account/Login')
           // this.credentials = response.data;
    
      },
    }
    
  }
  </script>