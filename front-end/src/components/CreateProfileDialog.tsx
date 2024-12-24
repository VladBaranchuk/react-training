import * as React from 'react';
import { Dialog, DialogActionsBar } from '@progress/kendo-react-dialogs';
import { Form, Field, FormElement, FormRenderProps, FieldWrapper } from '@progress/kendo-react-form';
import { Input } from '@progress/kendo-react-inputs'
import { Button } from '@progress/kendo-react-buttons';
import { createProfile } from '../api/profileController/ProfileController';
import { CreateProfile } from '../api/profileController/Models';
import { useDispatch } from 'react-redux';

interface ICreateProfiledialog {
    visible: boolean,
    setVisible: React.Dispatch<React.SetStateAction<boolean>>
}

const CreateProfileDialog: React.FC<ICreateProfiledialog> = ({visible, setVisible}) => {

    var dispatch = useDispatch();

    const toggleDialog = () => 
        setVisible(!visible);

    const handleSubmit = (dataItem: { [name: string]: any }) => {
        createProfile(dataItem as CreateProfile)
        .then(data => {
            if (data !== null) {
                dispatch({type: "action/addProfile", payload: data});
                console.log('Loaded: ', data);
            }
        });
    }

    

    return (
    <Dialog title={'Create a new profile'} onClose={toggleDialog}>
        <DialogActionsBar>
        <Form
            onSubmit={handleSubmit}
            render={(formRenderProps: FormRenderProps) => (
                <FormElement style={{ maxWidth: 800 }}>
                    <fieldset className={'k-form-fieldset'}>
                        <legend className={'k-form-legend'}>Please fill in the fields:</legend>
                        <FieldWrapper>
                            <Field
                                name={'firstName'}
                                component={Input}
                                labelClassName={'k-form-label'}
                                label={'First name'}/>
                        </FieldWrapper>
                        <FieldWrapper>
                            <Field
                                name={'lastName'}
                                component={Input}
                                labelClassName={'k-form-label'}
                                label={'Last name'}/>

                        </FieldWrapper>
                        <FieldWrapper>
                            <Field
                                name={'weight'}
                                component={Input}
                                labelClassName={'k-form-label'}
                                label={'Weight'}/>
                        </FieldWrapper>
                    </fieldset>
                    <div className="k-form-buttons">
                        <Button disabled={!formRenderProps.allowSubmit}>Submit</Button>
                    </div>
                </FormElement>
            )}/>
        </DialogActionsBar>
    </Dialog>
    );
};
export default CreateProfileDialog;

